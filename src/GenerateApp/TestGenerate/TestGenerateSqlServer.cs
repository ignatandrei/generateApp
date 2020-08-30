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
            var t = new TableGenerator[2];
            t[0] = new TableGenerator();
            t[0].table = new Table();
            t[0].table.name = "Department";
            t[0].table.fields = new List<Field>();
            t[0].table.fields.Add(new Field() { name = "IDDepartment" });
            t[0].table.fields.Add(new Field() { name = "Name" });

            t[1] = new TableGenerator();
            t[1].table = new Table();
            t[1].table.name = "Employee";
            t[1].table.fields = new List<Field>();
            t[1].table.fields.Add(new Field() { name = "IDEmployee" });
            t[1].table.fields.Add(new Field() { name = "Name" });
            t[1].table.fields.Add(new Field() { name = "IDDepartment" });
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

        }
    }
}
