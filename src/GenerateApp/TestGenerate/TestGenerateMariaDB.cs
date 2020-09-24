using GenerateApp.Controllers;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TestGenerate
{
    public class TestGenerateMariaDB
    {
        private readonly ITestOutputHelper output;
        static GenerateAppV1 gen()
        {
            var g = new GenerateAppV1();
            g.payLoadConn = payload();
            var t = new TableGenerator[2];
            t[0] = new TableGenerator();
            t[0].table = new Table();
            t[0].table.name = "table_test";
            t[0].table.fields = new List<Field>();
            t[0].table.fields.Add(new Field() { name = "table_id" });
            t[0].table.fields.Add(new Field() { name = "name" });

            t[1] = new TableGenerator();
            t[1].table = new Table();
            t[1].table.name = "table_two";
            t[1].table.fields = new List<Field>();
            t[1].table.fields.Add(new Field() { name = "column_1" });
            t[1].table.fields.Add(new Field() { name = "column_2" });
            g.input = t;
            return g;
        }
        static PayLoadConn payload()
        {
            var p = new PayLoadConn();
            p.connType = connTypes.MARIADB.ToString();
            p.connDatabase = "test_schema";
            p.connHost = "alex360.go.ro";
            p.connPort = "85";
            p.connUser = "root";
            p.connPassword = "datatocode";
            return p;
        }
        public TestGenerateMariaDB(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public async void TestTables()
        {
            var p = payload();
            var ass = await p.FromPayloadConn();
            if (!ass.Success)
            {
                output.WriteLine(ass.error);
            }
            Assert.True(ass.Success);
            Assert.True(ass.input?.Length > 0);

        }
        [Theory]
        [InlineData(@"E:\ignatandrei\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll")]
        public async void TestGenerate(string pathGenerate)
        {
            var app = gen();
            int errors = 0;
            await foreach(var item in app.Validate())
            {
                errors++;
                output.WriteLine(item.ErrorMessage);
            }

            Assert.Equal(0,errors );
            var info = await app.GenerateInfoData();
            info.folderGenerator = pathGenerate;
            info.pathFile = @"E:\test\a.txt";
            var data = await info.GenerateApp();
            if (!data)
            {
                output.WriteLine(info.logs[info.logs.Count - 2]);
                output.WriteLine(info.logs[info.logs.Count - 1]);
            }
            Assert.True(data);
        }


    }
}