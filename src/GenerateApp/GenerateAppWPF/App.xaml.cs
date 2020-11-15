using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GenerateAppWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += App_Startup;
        }
        
        private void App_Startup(object sender, StartupEventArgs e)
        {            

            GenerateFromDB.Program.Main(new string[1] { "--urls http://localhost:9100" });
        }
    }
}
