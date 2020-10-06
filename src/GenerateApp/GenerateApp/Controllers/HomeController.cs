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
using System.Collections.Concurrent;
using Stankins.FileOps;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace GenerateApp.Controllers
{
    public class HomeController : Controller
    {
        public static ConcurrentDictionary<string,InfoData> data = new ConcurrentDictionary<string, InfoData>();
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
        //[HttpPost]
        //public async Task<IActionResult> UploadCSV(string id)
        //{
        //    if (string.IsNullOrWhiteSpace(id))
        //        return Content("please add some content to the csv");
        //    var name = "CSV";
        //    var i = new InfoData(SourceData.CSV)
        //    {
        //        logs = new Logs(),
        //        name = name,
        //        folderGenerator = Path.Combine(environment.WebRootPath, "GenerateAll"),
        //        pathFile = ""

        //    };

        //    do
        //    {
        //        name = name + DateTime.UtcNow.ToString("yyyyMMddHHmmss");

        //    } while (!data.TryAdd(name, i));
        //    i.name = name;
        //    var path = Path.Combine(environment.WebRootPath,name+".csv");
        //    i.pathFile = path;

        //    await System.IO.File.WriteAllTextAsync(name + ".csv", id);
        //    var t = new Task(async i =>
        //    {
        //        var info = i as InfoData;
        //        info.result = await GenerateApp(i as InfoData);
        //    }
        //    , i);

        //    return RedirectToAction("Info", new { id = name });

        //}
        //[HttpPost]
        //public async Task<TablesFromDataSource> MariaDBConnectionToObtainFields(string connection)
        //{
        //    return await connection.FromMariaDB();
        //}
        //to be deleted

        //[HttpGet]
        //public GenerateAppV1 GenerateApp("NETCore3.1", "Angular10.0")
        //{
        //    var v = new GenerateAppV1();
        //    v.payLoadConn = new PayLoadConn();
            
        //    v.input = new TableGenerator[1];
        //    v.input[0] = new TableGenerator()
        //    {
        //        crudEndpoints =new CrudEndpoints(),
        //        table=  new Table()
        //        {
        //            fields = new List<Field>()
        //            {
        //                new Field()
        //                {
        //                     name="testField",
        //                     originalType= "nvarchar(30)"
        //                }
        //            },

        //            name = "testTable"
        //        }

        //    };
        //    return v;
        //}
        ////alex
        //[HttpPost]
        //public GenerateAppV1 GenerateApp([FromBody] GenerateAppV1 app)
        //{
        //    return app;
        //}
        //    //alex
        //    [HttpPost]
        //public async Task<TablesFromDataSource> FindTables([FromBody] PayLoadConn payLoadConn)
        //{
        //    return await payLoadConn.FromPayloadConn();

        //}
       
        //public async Task<TablesFromDataSource> UploadExcelToObtainFields(IFormFile file)
        //{
        //    try
        //    {
        //        string name = Path.GetFileNameWithoutExtension(file.FileName);
        //        var path = Path.Combine(
        //                  environment.WebRootPath,
        //                  Path.GetFileName(file.FileName));
        //        if (System.IO.File.Exists(path))
        //            System.IO.File.Delete(path);

        //        using (var stream = new FileStream(path, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }
        //        return await path.FromExcel();

        //    }
        //    catch (Exception ex)
        //    {
        //        var res = new TablesFromDataSource();
        //        res.Success = false;
        //        res.error = ex.Message + "!!" + ex.StackTrace;
        //        return res;
        //    }
        //}

        //public IActionResult TestExcel()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> UploadFileCSV([FromForm]string myCSV)
        //{
        //    string nameFile ="csv"+ DateTime.UtcNow.ToString("yyyyMMddHHmmss") + ".csv";
        //    nameFile = Path.Combine(
        //              environment.WebRootPath,
        //              nameFile);
        //    await System.IO.File.WriteAllTextAsync(nameFile, myCSV);
        //    var recCSV = new ReceiverCSVFile(nameFile);
        //    var data = await recCSV.TransformData(null);
        //    var table = data.DataToBeSentFurther.First().Value;
        //    nameFile = nameFile.Replace(".csv", ".xlsx");
        //    var res= await WriteExcelFromDataTable(table, nameFile);
        //    if (res)
        //    {
        //        var name = GenerateExcelFromPathFile(nameFile);
        //        return RedirectToAction("Info", new { id = name });
        //    }
        //    else
        //    {
        //        return Content($"error happened. Please send email to ignatandrei@yahoo.com with {Path.GetFileNameWithoutExtension(nameFile)} ");
        //    }
            
        //}
        //private async Task<bool> WriteExcelFromDataTable(DataTable dt,string excelFileName)
        //{
            
        //    IWorkbook workbook = new XSSFWorkbook();
        //    ISheet worksheet = workbook.CreateSheet(Path.GetFileNameWithoutExtension(excelFileName));
        //    var nrCols = dt.Columns.Count;
        //    var nrRows = dt.Rows.Count;
        //    var row = worksheet.CreateRow(0);
        //    for (int i = 0; i < nrCols; i++)
        //    {

        //        row.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
        //    }

        //    for (int iRow = 0; iRow < nrRows; iRow++)
        //    {
        //        DataRow dRow = dt.Rows[iRow];
        //        row = worksheet.CreateRow(iRow+1);

        //        for (int i = 0; i < nrCols; i++)
        //        {

        //            row.CreateCell(i).SetCellValue((dRow[i]?.ToString()??""));
        //        }
        //    }

        //    using (FileStream fileWriter = System.IO.File.Create(excelFileName))
        //    {
        //        workbook.Write(fileWriter);
        //        fileWriter.Close();
        //    }
        //    //workbook.Close();
        //    worksheet = null;
        //    workbook = null;
        //    return true;
        //}

        public string GenerateExcelFromPathFile(string path)
        {
            string name = Path.GetFileName(path);
            name = new String(name.Where(it=> it == '.' || Char.IsLetterOrDigit(it)).ToArray());
            var i = new InfoData(connTypes.Excel)
            {
                logs = new Logs(),
                name = name,
                folderGenerator = Path.Combine(environment.WebRootPath, "GenerateAll"),
                pathFile = path

            };
            do
            {
                name = name + DateTime.UtcNow.ToString("yyyyMMddHHmmss");

            } while (!data.TryAdd(name, i));
            
            i.name = name;
            Console.WriteLine($"added {name} to generatoes");

            Task t = new Task(async i =>
            {
                var info = i as InfoData;
                info.result = !string.IsNullOrWhiteSpace(await GenerateApp(i as InfoData));
            }
            , i);
            t.Start();
            return i.name;
        }
        
         [HttpPost]
        public async Task<IActionResult> UploadFileExcel (IFormFile file)
        {
            
            if (file == null || file.Length == 0)
                return Content("file not selected");
            string name = Path.GetFileNameWithoutExtension(file.FileName);
            var path = Path.Combine(
                      environment.WebRootPath,
                      Path.GetFileName(file.FileName));
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            name = GenerateExcelFromPathFile(path);
            
            return RedirectToAction("Info",new { id = name });
        }
        public async Task<string> GenerateApp(InfoData i)
        {
            try
            {
                while (NumberItemsInProgress(i.startedDate) >0)
                {
                    i.logs.AddLog(i.name,"There is another application in progress. Please wait ");
                    await Task.Delay(5*1000);
                }
                i.logs.AddLog(i.name,"Start generating app");

                var result = await i.GenerateApp("NETCore3.1", "Angular10.0");

                i.logs.AddLog(i.name,$"Done with result {result}");
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRRR: " + ex.Message);
                try
                {
                    i.result = false;
                    i.logs.AddLog(i.name, ex.Message);
                }
                catch
                {
                }
                return null;
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
