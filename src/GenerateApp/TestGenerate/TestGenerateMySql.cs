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
            p.connDatabase = "sql7341223";
            p.connHost = "sql7.freemysqlhosting.net";
            p.connPort = "3306";
            p.connUser = "sql7341223";
            p.connPassword = "sSuvYBVdwu";
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
            var data = await info.GenerateApp("NETCore3.1", "Angular10.0");
            if (string.IsNullOrWhiteSpace(data))
            {
                output.WriteLine(info.logs[info.logs.Count - 2]);
                output.WriteLine(info.logs[info.logs.Count - 1]);
            }
            Assert.NotNull(data);
        }


    }
}