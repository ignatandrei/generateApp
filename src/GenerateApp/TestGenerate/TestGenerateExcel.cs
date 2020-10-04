using GenerateApp.Controllers;
using System;
using Xunit;
using Xunit.Abstractions;

namespace TestGenerate
{
    public class TestGenerateExcel
    {
        private readonly ITestOutputHelper output;

        public TestGenerateExcel(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Theory]
        [InlineData(@"E:\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll\ExcelTests\eu.xlsx")]
        //[InlineData(@"C:\Users\ignat\Desktop\Daily work list Greyline 20.03.xlsx")]
        public async void TestData(string file)
        {
            var i = new InfoData(connTypes.Excel)
            {
                logs = new Logs(),
                name = "testAndrei",
                folderGenerator = @"E:\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll",
                pathFile =  file
            };

            var res = await i.GenerateApp("NETCore3.1", "Angular10.0");
            output.WriteLine(i.logs[i.logs.Count - 2]);
            output.WriteLine(i.logs[i.logs.Count - 1]);
            Assert.True(res);

        }
    }
}
