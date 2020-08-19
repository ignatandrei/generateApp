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
using Stankins.MariaDB;
using System.Data;
using MySqlConnector;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Stankins.FileOps;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

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
        [HttpPost]
        public async Task<TablesFromDataSource> MariaDBConnectionToObtainFields(string connection)
        {
            try
            {
                var recData = new ReceiveMetadataFromDatabaseMariaDB (connection);

                var data = await recData.TransformData(null);

                var tables = data.FindAfterName("tables").Value.Rows;
                var columns = data.FindAfterName("columns").Value.Rows;
                var nameTables = new List<Table>();
                foreach(DataRow dr in tables)
                {
                    var t = new Table();
                    t.name = dr["name"].ToString();
                    var id = dr["id"].ToString();
                    nameTables.Add(t);
                    foreach (DataRow item in columns)
                    {
                        if(item["tableId"].ToString() == id)
                        {
                            var f = new Field();
                            f.name = item["name"].ToString();
                            f.originalType = item["type"].ToString();
                            t.fields.Add(f);
                        }
                    }
                }
                var res = new TablesFromDataSource();
                res.Success = true;
                res.input = nameTables.ToArray();

                return res;
            }
            catch (Exception ex)
            {
                var res = new TablesFromDataSource();
                res.Success = false;
                res.error = connection+"!!!"+ ex.Message + "!!" + ex.StackTrace;
                return res;
            }
        }
        [HttpPost]
        public async Task<TablesFromDataSource> FindTables([FromBody] PayLoadConn payLoadConn)
        {
            string connection = null;
            var ret = new TablesFromDataSource();
            ret.Success = false;
            var val = payLoadConn.connType;
            connTypes typeToLoad;
            try
            {
                typeToLoad=  Enum.Parse<connTypes>(val, true);
            }
            catch
            {
                ret.error = $" cannot parse {val} ";
                return ret;
            }
            try
            {
                switch (typeToLoad)
                {
                    case connTypes.MARIADB:
                        var b = new MySqlConnectionStringBuilder();
                        b.Database = payLoadConn.connDatabase;
                        b.Server = payLoadConn.connHost;
                        b.UserID = payLoadConn.connUser;
                        b.Password = payLoadConn.connPassword;
                        if(int.TryParse(payLoadConn.connPort, out var port))
                        {
                            b.Port = (uint)port;
                        }
                        connection = b.ConnectionString;
                        return await MariaDBConnectionToObtainFields(connection);
                    case connTypes.XLS:
                        var bytes = Convert.FromBase64String(payLoadConn.connFileContent);
                        var path = Path.Combine(
                                  environment.WebRootPath,
                                  payLoadConn.connFileName);
                        if (System.IO.File.Exists(path))
                            System.IO.File.Delete(path);



                        return await UploadExcelToObtainFields(path);
                    default:
                        ret.error = $"{val} is not implemented yet";
                        return ret;
                }
            }
            catch(Exception ex)
            {
                ret.error = connection;
                ret.error += "!!!" + ex.Message + "!!!" + ex.StackTrace;
                return ret;
            }

        }
        async Task<TablesFromDataSource> UploadExcelToObtainFields(string filePath)
        {
            try
            {
                var recExcel = new ReceiverExcel(filePath);

                var data = await recExcel.TransformData(null);

                var renameExcel = new TransformerRenameTable("it=>it.Contains(\".xls\")", "DataSource");

                data = await renameExcel.TransformData(data);

                var renameCol = new ChangeColumnName("SheetName", "TableName");
                data = await renameCol.TransformData(data);

                var ds = data.FindAfterName("DataSource").Value;
                var nrRowsDS = ds.Rows.Count;
                var nameTablesToRender = new Table[nrRowsDS];

                for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
                {
                    var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
                    var dt = data.FindAfterName(nameTable).Value;
                    var t = new Table();
                    t.name = dt.TableName;
                    nameTablesToRender[iRowDS] = t;
                }
                var res = new TablesFromDataSource();
                res.Success = true;
                res.input = nameTablesToRender;
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
                return await UploadExcelToObtainFields(path);

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
        public async Task<IActionResult> UploadFileCSV([FromForm]string myCSV)
        {
            string nameFile ="csv"+ DateTime.Now.Ticks+".csv";
            nameFile = Path.Combine(
                      environment.WebRootPath,
                      nameFile);
            await System.IO.File.WriteAllTextAsync(nameFile, myCSV);
            var recCSV = new ReceiverCSVFile(nameFile);
            var data = await recCSV.TransformData(null);
            var table = data.DataToBeSentFurther.First().Value;
            nameFile = nameFile.Replace(".csv", ".xlsx");
            var res= await WriteExcelFromDataTable(table, nameFile);
            if (res)
            {
                var name = GenerateExcelFromPathFile(nameFile);
                return RedirectToAction("Info", new { id = name });
            }
            else
            {
                return Content($"error happened. Please send email to ignatandrei@yahoo.com with {Path.GetFileNameWithoutExtension(nameFile)} ");
            }
            
        }
        private async Task<bool> WriteExcelFromDataTable(DataTable dt,string excelFileName)
        {
            
            IWorkbook workbook = new XSSFWorkbook();
            ISheet worksheet = workbook.CreateSheet(Path.GetFileNameWithoutExtension(excelFileName));
            var nrCols = dt.Columns.Count;
            var nrRows = dt.Rows.Count;
            var row = worksheet.CreateRow(0);
            for (int i = 0; i < nrCols; i++)
            {

                row.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
            }

            for (int iRow = 0; iRow < nrRows; iRow++)
            {
                DataRow dRow = dt.Rows[iRow];
                row = worksheet.CreateRow(iRow+1);

                for (int i = 0; i < nrCols; i++)
                {

                    row.CreateCell(i).SetCellValue((dRow[i]?.ToString()??""));
                }
            }

            using (FileStream fileWriter = System.IO.File.Create(excelFileName))
            {
                workbook.Write(fileWriter);
                fileWriter.Close();
            }
            //workbook.Close();
            worksheet = null;
            workbook = null;
            return true;
        }

        public string GenerateExcelFromPathFile(string path)
        {
            string name = Path.GetFileName(path);

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
            Console.WriteLine($"added {name} to generatoes");

            Task t = new Task(async i =>
            {
                var info = i as InfoData;
                info.result = await GenerateApp(i as InfoData);
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
