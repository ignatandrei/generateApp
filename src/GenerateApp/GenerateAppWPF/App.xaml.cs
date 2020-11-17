using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.IO.Compression;

namespace GenerateAppWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Process process;
        public App()
        {
            Console.WriteLine("start");
            ZipFile.ExtractToDirectory("GenerateFromDB.zip", ".", true);
            //string applicationDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //string file = Path.Combine(applicationDirectoryPath, "SNI.dll");
            //if (!File.Exists(file))
            //{                
            //    using (WebClient client = new WebClient())
            //    {
            //        client.DownloadFile("https://data-to-code.eu/app/SNI.dll.deploy", file);
            //    }
            //}
            //file = Path.Combine(applicationDirectoryPath, "Microsoft.Data.SqlClient.SNI.dll");
            //if (!File.Exists(file))
            //{
                
            //    using (WebClient client = new WebClient())
            //    {
            //        client.DownloadFile("https://data-to-code.eu/app/Microsoft.Data.SqlClient.SNI.dll.deploy", file);
            //    }
            //}
            this.Startup += App_Startup;
            this.Exit += App_Exit;
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            if (!process.HasExited)
                process.Kill(true);
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {

            Task.Run(() =>
            // GenerateFromDB.Program.Main(new string[1] { "--urls http://localhost:9100" })
            {
                 try
                 {
                    var dir = Path.Combine(Environment.CurrentDirectory, "publish");
                    var psi = new ProcessStartInfo(Path.Combine(dir, "GenerateFromDb.exe"));
                    psi.WorkingDirectory = dir;
                    psi.CreateNoWindow = true;
                    process = Process.Start(psi);
                     //GenerateFromDB.Program.Main(e.Args);
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.ToString());
                 }
             }
            );  
            //GenerateFromDB.Program.Main(e.Args);
        }
    }
}
