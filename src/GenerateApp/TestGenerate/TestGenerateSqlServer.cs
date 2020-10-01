using GenerateApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TestGenerate
{
    public class TestGenerateSqlServer
    {
        private readonly ITestOutputHelper output;
        static GenerateAppV1 gen()
        {
            var g = new GenerateAppV1();
            g.payLoadConn = payload();
            var t = new TableGenerator[3];
            t[0] = new TableGenerator();
            t[0].table = new Table();
            t[0].table.name = "dbo.Department";
            t[0].table.fields = new List<Field>();
            t[0].table.fields.Add(new Field() { name = "IDDepartment" });
            t[0].table.fields.Add(new Field() { name = "Name" });

            t[1] = new TableGenerator();
            t[1].table = new Table();
            t[1].table.name = "dbo.Employee";
            t[1].table.fields = new List<Field>();
            t[1].table.fields.Add(new Field() { name = "IDEmployee" });
            t[1].table.fields.Add(new Field() { name = "Name" });
            t[1].table.fields.Add(new Field() { name = "IDDepartment" });

            t[2] = new TableGenerator();
            t[2].table = new Table();
            t[2].table.name = "dbo.TestAndrei";
            t[2].table.fields = new List<Field>();
            t[2].table.fields.Add(new Field() { name = "id" });
            t[2].table.fields.Add(new Field() { name = "A2" });
            t[2].table.fields.Add(new Field() { name = "A3" });
            t[2].table.fields.Add(new Field() { name = "A4" });
            t[2].table.fields.Add(new Field() { name = "A5" });
            t[2].table.fields.Add(new Field() { name = "A6" });
            t[2].table.fields.Add(new Field() { name = "A7" });
            t[2].table.fields.Add(new Field() { name = "A8" });
            t[2].table.fields.Add(new Field() { name = "A9" });
            t[2].table.fields.Add(new Field() { name = "A10" });
            t[2].table.fields.Add(new Field() { name = "A11" });
            t[2].table.fields.Add(new Field() { name = "A12" });
            t[2].table.fields.Add(new Field() { name = "A13" });
            t[2].table.fields.Add(new Field() { name = "A14" });
            t[2].table.fields.Add(new Field() { name = "A15" });
            t[2].table.fields.Add(new Field() { name = "A16" });
            t[2].table.fields.Add(new Field() { name = "A17" });
            t[2].table.fields.Add(new Field() { name = "A18" });
            t[2].table.fields.Add(new Field() { name = "A19" });
            t[2].table.fields.Add(new Field() { name = "A20" });
            t[2].table.fields.Add(new Field() { name = "A21" });
            t[2].table.fields.Add(new Field() { name = "A22" });
            t[2].table.fields.Add(new Field() { name = "A23" });
            t[2].table.fields.Add(new Field() { name = "A24" });
            t[2].table.fields.Add(new Field() { name = "A25" });
            t[2].table.fields.Add(new Field() { name = "A26" });
            t[2].table.fields.Add(new Field() { name = "A27" });
            t[2].table.fields.Add(new Field() { name = "A28" });
            t[2].table.fields.Add(new Field() { name = "A29" });
            t[2].table.fields.Add(new Field() { name = "A30" });
            t[2].table.fields.Add(new Field() { name = "A31" });
            t[2].table.fields.Add(new Field() { name = "A32" });
            t[2].table.fields.Add(new Field() { name = "A33" });
            t[2].table.fields.Add(new Field() { name = "A34" });



            g.input = t;
            return g;
        }
        static PayLoadConn payload()
        {
            var p = new PayLoadConn();
            p.connType = connTypes.MSSQL.ToString();
            p.connDatabase = "tests";
            p.connHost = ".";
            p.connPort = "";
            p.connUser = "sa";
            p.connPassword = "yourStrong(!)Password";
            return p;
        }
        public TestGenerateSqlServer(ITestOutputHelper output)
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
            Assert.True(ass.tables?.Length>0);

        }

         [Theory]
        [InlineData(@"E:\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll")]
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
            var typeToLoad = Enum.Parse<connTypes>(app.payLoadConn.connType, true);

            var info = await app.GenerateInfoData(typeToLoad);
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
