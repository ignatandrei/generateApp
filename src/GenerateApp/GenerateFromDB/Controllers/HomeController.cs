using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GenerateApp.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GenerateFromDB.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> logger;
        private readonly IWebHostEnvironment environment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            this.logger = logger;
            this.environment = environment;
        }
        [HttpPost]
        public async Task<TablesFromDataSource> FindTables([FromBody] PayLoadConn payLoadConn)
        {
            return await payLoadConn.FromPayloadConn();
        }
        
        [HttpPost]
        public async Task<string> GenerateApp([FromBody] GenerateAppV1 app)
        {
            await foreach (var item in app.Validate())
            {
                throw new ArgumentException("validation error:" + item.ErrorMessage,string.Join("m", item.MemberNames));
            }
            var info = app.GenerateInfoData();
            info.folderGenerator = Path.Combine(environment.WebRootPath, "GenerateAll");
            info.pathFile = Path.Combine(environment.WebRootPath,app.payLoadConn.connDatabase,"a.txt");
            var data = await info.GenerateApp();
            if (!data)
            {
                Console.WriteLine(info.logs[info.logs.Count - 2]);
                Console.WriteLine(info.logs[info.logs.Count - 1]);
                throw new Exception(info.logs[info.logs.Count - 1]);
            }
            string pathDir =Path.GetDirectoryName (info.folderGenerator);
            return pathDir;
        }
        [HttpPost]
        public TableGenerator[] tableGenerator([FromBody] Table[] tables)
        {
            var ret = new TableGenerator[tables.Length];
            for (int i = 0; i < tables.Length; i++)
            {
                
                var t = new TableGenerator();
                t.table = tables[i];
                t.crudEndpoints = new CrudEndpoints()
                {
                    Create = true,
                    Delete = true,
                    List = true,
                    Update = true
                };
                ret[i] = t;
            }
            return ret;
        }
    }
}
