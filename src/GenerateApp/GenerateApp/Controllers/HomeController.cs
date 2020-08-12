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
using System.Collections.Concurrent;
using StankinsObjects;
using Stankins.Excel;

namespace GenerateApp.Controllers
{
    public class HomeController : Controller
    {
        static ConcurrentDictionary<string,InfoData> data = new ConcurrentDictionary<string, InfoData>();
        public static int NumberItemsInProgress(DateTime fromDate)
        {
            return data.Count(it => 
            it.Value.startedDate < fromDate &&
            it.Value.InProgress());
        }
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
        public async Task<IActionResult> UploadCSV(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return Content("please add some content to the csv");
            var name = "CSV";
            var i = new InfoData(SourceData.CSV)
            {
                logs = new List<string>(),
                name = name,
                folderGenerator = Path.Combine(environment.WebRootPath, "GenerateAll"),
                pathFile = ""

            };

            do
            {
                name = name + DateTime.Now.Ticks;

            } while (!data.TryAdd(name, i));
            i.name = name;
            var path = Path.Combine(environment.WebRootPath,name+".csv");
            i.pathFile = path;

            await System.IO.File.WriteAllTextAsync(name + ".csv", id);
            var t = new Task(async i =>
            {
                var info = i as InfoData;
                info.result = await GenerateApp(i as InfoData);
            }
            , i);

            return RedirectToAction("Info", new { id = name });

        }
        public async Task<TablesFromDataSource> UploadExcelToObtainFields(IFormFile file)
        {
            try
            {
                string name = Path.GetFileNameWithoutExtension(file.FileName);
                var path = Path.Combine(
                          environment.WebRootPath,
                          Path.GetFileName(file.FileName));
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                var recExcel = new ReceiverExcel(path);

                var data = await recExcel.TransformData(null);

                var renameExcel = new TransformerRenameTable("it=>it.Contains(\".xls\")", "DataSource");

                data = await renameExcel.TransformData(data);

                var renameCol = new ChangeColumnName("SheetName", "TableName");
                data = await renameCol.TransformData(data);
                
                var ds = data.FindAfterName("DataSource").Value;
                var nrRowsDS = ds.Rows.Count;
                var nameTablesToRender = new string[nrRowsDS];

                for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
                {
                    var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
                    var dt = data.FindAfterName(nameTable).Value;
                    nameTablesToRender[iRowDS] = dt.TableName;
                }
                var res = new TablesFromDataSource();
                res.Success = true;
                res.TableNames = nameTablesToRender;
                return res;


            }
            catch (Exception ex)
            {
                var res = new TablesFromDataSource();
                res.Success = false;
                res.error = ex.Message + "!!" + ex.StackTrace;
                return res;
            }
        }

        public IActionResult TestExcel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            
            if (file == null || file.Length == 0)
                return Content("file not selected");
            string name = Path.GetFileNameWithoutExtension(file.FileName);
            var path = Path.Combine(
                      environment.WebRootPath,
                      Path.GetFileName(file.FileName));

            var i = new InfoData(SourceData.Excel)
            {
                logs = new List<string>(),
                name = name,
                folderGenerator = Path.Combine(environment.WebRootPath, "GenerateAll"),
                pathFile = path

            };
            do
            {
                name = name + DateTime.Now.Ticks;

            } while (!data.TryAdd(name, i));

            i.name = name;
            Console.WriteLine($"added {name} to {data} ");
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
           
            
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
                while (NumberItemsInProgress(i.startedDate) >0)
                {
                    i.logs.Add("There is another application in progress. Please wait ");
                    await Task.Delay(5*1000);
                }
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
