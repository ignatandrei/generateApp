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
using System.Threading.Tasks;

namespace GenerateAppTool
{
    class Program
    {

        static async Task<int> MariaDBOrMySql(connTypes typeToLoad, CommandLineApplication cmd)
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
            data.OutputToConsole();
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
            info.folderGenerator = data.folderWithTemplates;
            info.pathFile = Path.Combine(data.outputFolder,"a.txt");
            var res = await info.GenerateApp(data.backEnd, data.frontEnd);
            Console.WriteLine($"generated in folder {res}");

            return 0;

        }
        static DataToGenerateOptions data;
        static int Main(string[] args)
        {
            data = new DataToGenerateOptions();
            

            var app = new CommandLineApplication();
            //app.UnrecognizedArgumentHandling = UnrecognizedArgumentHandling.CollectAndContinue;

            string moreHelp = "";

            moreHelp += $"{Environment.NewLine}{Environment.NewLine} ";
            moreHelp += " Generates code from database ";
            moreHelp += $"{Environment.NewLine}{Environment.NewLine} ";
            moreHelp +=$"EXECUTE with {Environment.NewLine}{Environment.NewLine} generateApptool sqlserver -cn <your connection string here> ...";
            moreHelp += $"{Environment.NewLine}{Environment.NewLine} ";
            moreHelp += $"EXECUTE with {Environment.NewLine}{Environment.NewLine} generateApptool mysql -cn <your connection string here> ...";

            moreHelp += $"To modify how it is generated, see options above ";
            app.ExtendedHelpText = moreHelp;
            app.HelpOption("-h|--help", inherited:true);
            var tf = app.Option<string>("-tf|--templateFolder <folder>", "template Folder", CommandOptionType.SingleOrNoValue);           
            var bE = app.Option<string>("-be|--backEnd <name>", "backend name", CommandOptionType.SingleOrNoValue);
            var fE = app.Option<string>("-fe|--frontEnd <name>", "frontEnd name", CommandOptionType.SingleOrNoValue);

            var of = app.Option<string>("-of|--outputFolder <folder>", "output Folder", CommandOptionType.SingleOrNoValue);
            
            app.OnParsingComplete(p =>
            {
                if (tf.HasValue())
                {
                    data.folderWithTemplates = tf.Value();
                }
                if (bE.HasValue())
                {
                    data.backEnd = bE.Value();
                }
                if (fE.HasValue())
                {
                    data.frontEnd = fE.Value();
                }

                if (of.HasValue())
                {
                    data.outputFolder = of.Value();
                }

            });


            app.Command("_templates", cmd =>
            {
                var cmdList = new CommandLineApplication()
                {
                    Name = "list"
                };
                cmdList.OnExecute(() =>
                {
                    string generator = Path.Combine(data.folderWithTemplates, "describe.txt");
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
                cmd.OnExecute(() =>
                {
                    cmd.ShowHelp(); 
                });
            });
            app.Command("_about", cmd =>
            {
                cmd.OnExecute(()=>
                {
                    app.ShowVersion();
                    
                    Console.WriteLine("please see www.data-to-code.eu for updates");
                    Console.WriteLine("Generates code from databases");
                    var dbs = string.Join(Environment.NewLine,Enum.GetNames(typeof(connTypes)));
                    dbs = dbs.Replace(connTypes.None.ToString(), "");
                    Console.WriteLine(dbs);
                    Console.WriteLine("");
                    data.OutputToConsole();        
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
                    data.OutputToConsole();
                    var folder = await ImportExcel(fileName);
                    Console.WriteLine($"generated in folder {data}");
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
                     data.OutputToConsole();
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
                     info.folderGenerator = data.folderWithTemplates;
                     info.pathFile = Path.Combine(data.outputFolder,"a.txt");
                     var res = await info.GenerateApp(data.backEnd, data.frontEnd);
                     Console.WriteLine($"generated in folder {res}");

                     return 0;
                 });


             });


            app.Command("mariadb", cmd =>
            {

                var optionConnectionString = cmd.Option<string>("-cn|--connectionstring <connectionstring>", "connection string", CommandOptionType.SingleValue);
                cmd.OnExecuteAsync(async ct =>
                {
                    return await MariaDBOrMySql(connTypes.MariaDB, cmd);

                });


            });
            app.Command("mysql", cmd =>
            {
                var optionConnectionString = cmd.Option<string>("-cn|--connectionstring <connectionstring>", "connection string", CommandOptionType.SingleValue);

                cmd.OnExecuteAsync(async ct =>
                {
                    return await MariaDBOrMySql(connTypes.MYSQL, cmd);
                });


            });
            
            app.OnExecute(() =>
            {
                Console.WriteLine("Specify a subcommand");
                app.ShowVersion();
                app.ShowHelp();
                return 1;
            });
            return app.Execute(args);
        }

        private static async Task<string> ImportExcel(string fileName)
        {
            var i = new InfoData(connTypes.Excel);
            i.name = "andrei";
           
            i.pathFile = fileName;
            // replace this
            i.folderGenerator = data.folderWithTemplates;
            
            var ret= await i.GenerateApp(data.backEnd, data.frontEnd);
            if(string.IsNullOrEmpty(ret))
            {
                foreach (var l in i.logs)
                    Console.WriteLine(l);
            }
            return (ret);
        }
    }
}
