using GenerateApp.Controllers;
using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.HelpText;
using MySqlConnector;
using Newtonsoft.Json;
using StankinsObjects;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GenerateAppTool
{
    class Program
    {

        static async Task<int> MariaDBOrMySql(connTypes typeToLoad, CommandLineApplication cmd, string folderWithTemplates, string outputFolder)
        {
            const string cnOpt = "cn";
            var optionConnectionString = cmd.GetOptions().First(it=>it.ShortName==cnOpt);

            Console.WriteLine("start "+typeToLoad);
            if (!optionConnectionString.HasValue())
            {
                Console.WriteLine($"Specify -{cnOpt}");
                cmd.ShowHelp();
                return 1;
            }
            string cn = optionConnectionString.Value();

            var scsb = new MySqlConnectionStringBuilder(cn);

            Console.WriteLine($"start import {cn}");
            var g = new GenerateAppV1();

            g.payLoadConn = new PayLoadConn()
            {
                connDatabase = scsb.Database,
                connHost = scsb.Server,
                connPort = scsb.Port.ToString(),
                connPassword = scsb.Password,
                connUser = scsb.UserID,
                connType = typeToLoad.ToString()
            };
            //var typeToLoad = Enum.Parse<connTypes>(g.payLoadConn.connType, true);

            g.input = await g.ReadAllFromDB();
            var info = await g.GenerateInfoData(typeToLoad);
            info.folderGenerator = folderWithTemplates;
            info.pathFile = Path.Combine(outputFolder,"a.txt");
            var data = await info.GenerateApp("NETCore3.1", "Angular10.0");
            return 0;

        }
        static int Main(string[] args)
        {

            var pathDll = Assembly.GetEntryAssembly().Location;
            var folderWithTemplates = Path.GetDirectoryName(pathDll);
            folderWithTemplates = Path.Combine(folderWithTemplates, "GenerateAll");
            folderWithTemplates = @"E:\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll";

            string outputFolder = Environment.CurrentDirectory;
            var app = new CommandLineApplication();
            app.HelpOption("-h|--help", inherited:true);
            var tf = app.Option<string>("-tf|--templateFolder <folder>", "template Folder", CommandOptionType.SingleOrNoValue);
            if (tf.HasValue())
            {
                folderWithTemplates = tf.Value();
            }

            var of= app.Option<string>("-of|--outputFolder <folder>", "output Folder", CommandOptionType.SingleOrNoValue);
            if (of.HasValue())
            {
                outputFolder = of.Value();
            }
            app.Command("templates", cmd =>
            {
                var cmdList = new CommandLineApplication()
                {
                    Name = "list"
                };
                cmdList.OnExecute(() =>
                {
                    string generator = Path.Combine(folderWithTemplates, "describe.txt");
                    if (!File.Exists(generator))
                    {
                        Console.WriteLine($"cannot find file {generator}");
                        return 1;
                    }
                    var stData = JsonConvert.DeserializeObject<StankinsGenerator>(File.ReadAllText(generator));
                    foreach (var item in stData.backend)
                    {
                        Console.WriteLine("backend :" + item.name);

                    }

                    foreach (var item in stData.frontend)
                    {
                        Console.WriteLine("frontend :" + item.name);

                    }
                    return 0;
                });
                cmd.AddSubcommand(cmdList);
                cmd.ShowHelp();

            });
            app.Command("about", cmd =>
            {
                cmd.OnExecute(()=>
                {
                    Console.WriteLine("please see www.data-to-code.eu for updates");
                    Console.WriteLine("Generates code from databases");
                    var dbs = string.Join(Environment.NewLine,Enum.GetNames(typeof(connTypes)));
                    dbs = dbs.Replace(connTypes.None.ToString(), "");
                    Console.WriteLine(dbs);
                    Console.WriteLine("");
                    Console.WriteLine($"templates folder = {folderWithTemplates}");

                    Console.WriteLine("see below about how to generate");
                    Console.WriteLine("");

                    app.ShowHelp();

                    Console.WriteLine("");
                    Console.WriteLine("Made by Andrei Ignat, ignatandrei@yahoo.com");
                    Console.WriteLine("Made by Alexandru Badita, alexandru360@gmail.com");
                    
                    return 0;
                });
            });
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
                    await ImportExcel(fileName, folderWithTemplates);
                    return 0;
                });


            });

            app.Command("sqlserver", cmd =>
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
                     var typeToLoad = Enum.Parse<connTypes>(g.payLoadConn.connType, true);

                     var info =await g.GenerateInfoData(typeToLoad);
                     info.folderGenerator = folderWithTemplates;
                     info.pathFile = Path.Combine(outputFolder,"a.txt");
                     var data = await info.GenerateApp("NETCore3.1", "Angular10.0");
                     return 0;
                 });


             });


            app.Command("mariadb", cmd =>
            {

                var optionConnectionString = cmd.Option<string>("-cn|--connectionstring <connectionstring>", "connection string", CommandOptionType.SingleValue);
                cmd.OnExecuteAsync(async ct =>
                {
                    return await MariaDBOrMySql(connTypes.MariaDB, cmd, folderWithTemplates, outputFolder);

                });


            });
            app.Command("mysql", cmd =>
            {
                var optionConnectionString = cmd.Option<string>("-cn|--connectionstring <connectionstring>", "connection string", CommandOptionType.SingleValue);

                cmd.OnExecuteAsync(async ct =>
                {
                    return await MariaDBOrMySql(connTypes.MYSQL, cmd,folderWithTemplates, outputFolder);
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

        private static async Task<bool> ImportExcel(string fileName, string folderWithTemplates)
        {
            var i = new InfoData(connTypes.Excel);
            i.name = "andrei";
           
            i.pathFile = fileName;
            // replace this
            i.folderGenerator = folderWithTemplates;
            
            var ret= await i.GenerateApp("NETCore3.1", "Angular10.0");
            if(!ret)
            {
                foreach (var l in i.logs)
                    Console.WriteLine(l);
            }
            return ret;
        }
    }
}
