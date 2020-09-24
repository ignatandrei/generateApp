using GenerateApp.Controllers;
using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.HelpText;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GenerateAppTool
{
    class Program
    {
        static int Main(string[] args)
        {
            
            var app = new CommandLineApplication();
            app.HelpOption("-h|--help", inherited:true);

            app.Command("excel", async cmd =>
            {
                var optionFileName = cmd.Option("-f|--file <filename>", "import data file name", CommandOptionType.SingleOrNoValue);
                cmd.OnExecuteAsync(async ct => 
                {
                    if (!optionFileName.HasValue())
                    {
                        Console.WriteLine("please add file path");
                        cmd.ShowHelp();
                        return 1;
                    }
                    string fileName = optionFileName.Value();
                    Console.WriteLine($"start import {fileName}");
                    await ImportExcel(fileName);
                    return 0;
                });


            });

            app.Command("sqlserver", async cmd =>
             {
                 var optionConnectionString = cmd.Option<string>("-cn|--connectionstring <connectionstring>", "connection string", CommandOptionType.SingleValue);

                 cmd.OnExecuteAsync( async ct =>
                 {


                     Console.WriteLine("start sql server");
                     if (!optionConnectionString.HasValue())
                     {
                         Console.WriteLine("Specify a subcommand");
                         cmd.ShowHelp();
                         return 1;
                     }
                     string cn = optionConnectionString.Value();
                     
                     var scsb = new SqlConnectionStringBuilder(cn);

                     Console.WriteLine($"start import {cn}");
                     var g = new GenerateAppV1();
                     
                     g.payLoadConn = new PayLoadConn()
                     {
                         connDatabase = scsb.InitialCatalog,
                         connHost = scsb.DataSource,
                         connPassword = scsb.Password,
                         IntegratedSecurity = scsb.IntegratedSecurity,
                         connUser = scsb.UserID,
                         connType = connTypes.MSSQL.ToString()
                     };
                     g.input = await g.ReadAllFromDB();
                     var info = g.GenerateInfoData();
                     info.folderGenerator = @"E:\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll";
                     info.pathFile = @"E:\test\a.txt";
                     var data = await info.GenerateApp();
                     return 0;
                 });


             });
            app.OnExecute(() =>
            {
                Console.WriteLine("Specify a subcommand");
                app.ShowHelp();
                return 1;
            });
            return app.Execute(args);
        }

        private static async Task<bool> ImportExcel(string fileName)
        {
            var i = new InfoData(SourceData.Excel);
            i.name = "andrei";
           
            i.pathFile = fileName;
            // replace this
            i.folderGenerator = @"E:\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll";
            var ret= await i.GenerateApp();
            if(!ret)
            {
                foreach (var l in i.logs)
                    Console.WriteLine(l);
            }
            return ret;
        }
    }
}
