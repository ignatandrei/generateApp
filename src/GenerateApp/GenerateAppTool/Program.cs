using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.HelpText;
using System;

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
            app.OnExecuteAsync(async cancellationToken =>  
            {
                switch (optionType.Value()?.ToLower())
                {
                    case null:
                        return;
                    case "excel":
                        Console.WriteLine("start excel");
                        if (!optionFileName.HasValue())
                        {
                            Console.WriteLine("please add file name");
                        }
                        string fileName = optionFileName.Value();
                        Console.WriteLine($"start import {fileName}");
                        break;
                    default:
                        throw new ArgumentException($"not found {optionType.Value()}");
                }
            });

            return app.Execute(args);
        }
    }
}
