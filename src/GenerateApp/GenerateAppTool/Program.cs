using GenerateApp.Controllers;
using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.HelpText;
using System;
using System.Threading.Tasks;

namespace GenerateAppTool
{
    class Program
    {
        static int Main(string[] args)
        {
            
            var app = new CommandLineApplication();
            app.HelpOption("-h|--help");
            var optionType = app.Option("-t|--type <importdata>", "import data type - now excel", CommandOptionType.SingleValue);
            var optionFileName = app.Option("-f|--file <filename>", "import data file name", CommandOptionType.SingleOrNoValue);
            var optionConnectionString = app.Option("-cn|--connectionstring <connectionstring>", "connection string", CommandOptionType.SingleOrNoValue);
            
            app.OnExecuteAsync(async cancellationToken =>  
            {
                switch (optionType.Value()?.ToLower())
                {
                    case null:
                        return;
                    case "sqlserver":
                        Console.WriteLine("start sql server");
                        if (!optionConnectionString.HasValue())
                        {
                            Console.WriteLine("please add connection string");
                        }
                        string cn = optionConnectionString.Value();
                        Console.WriteLine($"start import {cn}");
                        return;
                    case "excel":
                        Console.WriteLine("start excel");
                        if (!optionFileName.HasValue())
                        {
                            Console.WriteLine("please add file name");
                        }
                        string fileName = optionFileName.Value();
                        Console.WriteLine($"start import {fileName}");
                        await ImportExcel(fileName);
                        break;
                    default:
                        throw new ArgumentException($"not found {optionType.Value()}");
                }
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
