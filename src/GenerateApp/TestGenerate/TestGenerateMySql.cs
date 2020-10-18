using GenerateApp.Controllers;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestGenerate
{
    public class TestGenerateMySql
    {
        private readonly ITestOutputHelper output;
        static async Task<GenerateAppV1> gen()
        {
            var g = new GenerateAppV1();
            g.payLoadConn = payload();
            
            g.input = await g.ReadAllFromDB();
            return g;
        }
        static PayLoadConn payload()
        {
            var p = new PayLoadConn();
            p.connType = connTypes.MYSQL.ToString();
            //p.connDatabase = "sql7341223";
            //p.connHost = "sql7.freemysqlhosting.net";
            //p.connPort = "3306";
            //p.connUser = "sql7341223";
            //p.connPassword = "sSuvYBVdwu";
            p.connDatabase = "4data-to-code";
            p.connHost = "alex360.go.ro";
            p.connPort = "85";
            p.connUser = "user4code";
            p.connPassword = "user4code";
            return p;
        }
        public TestGenerateMySql(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public async void TestTables()
        {
            var p = payload();
            var typeToLoad = Enum.Parse<connTypes>(p.connType, true);
            var ass = await p.FromPayloadConn();
            if (!ass.Success)
            {
                output.WriteLine(ass.error);
            }
            Assert.True(ass.Success);
            Assert.True(ass.tables?.Length > 0);
            foreach(var t in ass.tables)
            {
                foreach(var q in t.fields)
                {
                    Console.WriteLine(q.DotNetType(typeToLoad));
                }
            }

        }
        [Theory]
        [InlineData(@"E:\ignatandrei\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll")]
        public async void TestGenerate(string pathGenerate)
        {
            var app = await gen();
            int errors = 0;
            await foreach(var item in app.Validate())
            {
                errors++;
                output.WriteLine(item.ErrorMessage);
            }

            Assert.Equal(0,errors );
            var typeToLoad = Enum.Parse<connTypes>(app.payLoadConn.connType, true);

            var info = await app.GenerateInfoData(typeToLoad);
            info.folderGenerator = pathGenerate;
            info.pathFile = @"E:\test\a.txt";
            var data = await info.GenerateApp("express-api-template", null);
            if (string.IsNullOrWhiteSpace(data))
            {
                output.WriteLine(info.logs[info.logs.Count - 2]);
                output.WriteLine(info.logs[info.logs.Count - 1]);
            }
            Assert.NotNull(data);
        }


    }
}