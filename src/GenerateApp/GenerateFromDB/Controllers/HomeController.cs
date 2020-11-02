﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
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
        public async Task<ReturnData> GenerateApp([FromBody] GenerateAppV1 app)
        {
            await foreach (var item in app.Validate())
            {
                throw new ArgumentException("validation error:" + item.ErrorMessage, string.Join("m", item.MemberNames));
            }
            var typeToLoad = Enum.Parse<connTypes>(app.payLoadConn.connType, true);

            var info = await app.GenerateInfoData(typeToLoad);
            info.folderGenerator = Path.Combine(environment.WebRootPath, "GenerateAll");
            string dateNow = DateTime.Now.ToString("yyyyMMddHHmmss");
            info.pathFile = Path.Combine(environment.WebRootPath, dateNow, "conection.txt");
            var di = Directory.CreateDirectory(Path.GetDirectoryName(info.pathFile));
            System.IO.File.WriteAllText(info.pathFile, app.payLoadConn.ConnectionString());
            var data = await info.GenerateApp(app.output.ApiType, app.output.UiType);
            if (!string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine(info.logs[info.logs.Count - 2]);
                Console.WriteLine(info.logs[info.logs.Count - 1]);
                throw new Exception(info.logs[info.logs.Count - 1]);
            }

            string pathDir = Path.GetDirectoryName(info.pathFile);
            var powershellFile = Directory.GetFiles(pathDir, "generateWin.ps1", SearchOption.AllDirectories).FirstOrDefault();
            if (powershellFile == null)
                throw new ArgumentException("cannot find powershell docker file");

            var ps = new ProcessStartInfo();
            ps.FileName = "powershell.exe";
            ps.WorkingDirectory = Path.GetDirectoryName(powershellFile);
            ps.Arguments = powershellFile;
            ps.CreateNoWindow = false;
            Process.Start(ps).WaitForExit();

            string outDir = Path.Combine(Path.GetDirectoryName(powershellFile), "out", "netcore3.1", "win-x64");
            InfoData.CreateVDir(dateNow, outDir);

            string generated = Path.Combine(Path.GetDirectoryName(powershellFile), "generated");
            string zip = Path.Combine(outDir, "wwwroot", "generated.zip");
            ZipFile.CreateFromDirectory(generated, zip);

            // execute powershell
            return new ReturnData()
            {
                Site = dateNow,
                ZipGenerated = $"{dateNow}/generated.zip"
            };
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
