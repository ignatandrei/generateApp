using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerateApp.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenerateFromDB.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public async Task<TablesFromDataSource> FindTables([FromBody] PayLoadConn payLoadConn)
        {
            return await payLoadConn.FromPayloadConn();
        }
        
        [HttpPost]
        public async Task<GenerateAppV1> GenerateApp([FromBody] GenerateAppV1 app)
        {
            await foreach (var item in app.Validate())
            {
                throw new ArgumentException("validation error:" + item.ErrorMessage,string.Join("m", item.MemberNames));
            }
            return app;
        }
    }
}
