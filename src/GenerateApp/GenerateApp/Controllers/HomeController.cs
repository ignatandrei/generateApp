using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GenerateApp.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Runtime.CompilerServices;
using NPOI.SS.Formula.Functions;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace GenerateApp.Controllers
{
    public class HomeController : Controller
    {
        static Dictionary<string,InfoData> data = new Dictionary<string, InfoData>();

        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment environment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            this.environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string Keys()
        {
            return string.Join(';', data.Keys);
        }
            [HttpGet]
        public string Verify()
        {
            var t = typeof(Microsoft.CodeAnalysis.CSharp.Scripting.CSharpScript);
            return t.AssemblyQualifiedName;
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            
            if (file == null || file.Length == 0)
                return Content("file not selected");
            string name = Path.GetFileNameWithoutExtension(file.FileName);
            while(data.ContainsKey(name))         
            {
                name = name + DateTime.Now.Ticks;
            }

            var path = Path.Combine(
                        environment.WebRootPath,
                        Path.GetFileName( file.FileName));

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var i = new InfoData()
            {
                logs = new List<string>(),
                name = name,
                folderGenerator = Path.Combine(environment.WebRootPath, "template"),
                pathFile = path

            };
            data.Add(name, i);
            Task t = new Task(async i =>

            {
                var info = i as InfoData;
                info.result = await GenerateApp(i as InfoData);
            }
            , i);
            t.Start();
            return RedirectToAction("Info",new { id = name });
        }
        public async Task<bool> GenerateApp(InfoData i)
        {
            try
            {

                i.logs.Add("Start generating app");

                var result = await i.GenerateApp();

                i.logs.Add($"Done with result {result}");
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRRR: " + ex.Message);
                try
                {
                    i.result = false;
                    i.logs.Add(ex.Message);
                }
                catch
                {
                }
                return false;
            }
        }
        public ActionResult Info(string id)
        {
            var dataToDisplay = data[id];
            return View(dataToDisplay);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
