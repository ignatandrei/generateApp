using Newtonsoft.Json;
using Stankins.Excel;
using Stankins.FileOps;
using Stankins.Interfaces;
using Stankins.Razor;
using StankinsCommon;
using StankinsObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateApp.Controllers
{
    public class InfoData
    {
        public bool InProgress()
        {
            return result == null;
        }
        public bool? result;

        public string name { get; set; }
        public string pathFile { get; set; }
        public List<string> logs { get; set; }
        public string folderGenerator { get; internal set; }

        public string[] AssetsLinks { get; internal set; }
        public async  Task<bool> GenerateApp()
        {
            string folderGenerator = this.folderGenerator;
            string generator =Path.Combine( folderGenerator ,"describe.txt");
            var stData = JsonConvert.DeserializeObject<StankinsGenerator>(File.ReadAllText(generator));
            var backendFolderName = @"NETCore3.1";
            var frontendFolderName = @"Angular10.0";
            //frontendFolderName = @"Angular10.0Full";
            var backend = stData.backend.First(it => it.folder == backendFolderName);
            var frontEnd = stData.frontend.First(it => it.folder == frontendFolderName);
            //wt  new-tab -d C:\test\backend\NETCore3.1\TestWebAPI ; split-pane -d C:\test\frontend\Angular10.0
            var g = this.name;

            var outputFolder = Path.Combine(Path.GetDirectoryName(pathFile),g);
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);
            IDataToSent data;
            string excel = pathFile;
            logs.Add("generating output");
            logs.Add("start reading excel");

            var recExcel = new ReceiverExcel(excel);

            data = await recExcel.TransformData(null);
            logs.Add("start transforming renaming");

            var renameExcel = new TransformerRenameTable("it=>it.Contains(\".xls\")", "DataSource");

            data = await renameExcel.TransformData(data);
            logs.Add("start change names from sheet");

            var renameCol = new ChangeColumnName("SheetName", "TableName");
            data = await renameCol.TransformData(data);

            logs.Add("gathering data");

            IDataToSent Model = data;
            var ds = Model.FindAfterName("DataSource").Value;
            var nrRowsDS = ds.Rows.Count;
            var nameTablesToRender = new string[nrRowsDS];
            for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
            {
                var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
                var dt = Model.FindAfterName(nameTable).Value;
                Console.WriteLine(dt.TableName);
                nameTablesToRender[iRowDS] = dt.TableName;
            }

            var f = Path.Combine(outputFolder, g);
            Directory.CreateDirectory(f);
            try
            {
                logs.Add("copy generator");

                File.Copy(generator, Path.Combine(outputFolder, "describe.txt"), true);
                var backendFolder = Path.Combine(f, "backend", backendFolderName);
                var frontendFolder = Path.Combine(f, "frontend", frontendFolderName);
                logs.Add("copy backend");

                DirectoryCopy(Path.Combine(folderGenerator, "backend", backendFolderName), backendFolder, true);
                logs.Add("copy frontend");

                DirectoryCopy(Path.Combine(folderGenerator, "frontend", frontendFolderName), frontendFolder, true);
                logs.Add("generating files backend");

                foreach (var fileToCopy in backend.copyTableFiles)
                {
                    var pathFile = Path.Combine(backendFolder, fileToCopy);
                    string content = await File.ReadAllTextAsync(pathFile);
                    foreach (DataRow item in ds.Rows)
                    {
                        var nameTable = item["TableName"].ToString();
                        var data1 = Model.FindAfterName(nameTable).Value;

                        var newFileName = pathFile.Replace("@Name@", nameTable, StringComparison.InvariantCultureIgnoreCase);
                        var newContent = content.Replace("@Name@", nameTable, StringComparison.InvariantCultureIgnoreCase);
                        await File.WriteAllTextAsync(newFileName, newContent);

                    }
                    File.Delete(pathFile);
                }
                logs.Add("generating files frontend");
                foreach (var fileToCopy in frontEnd.copyTableFiles)
                {
                    var pathFile = Path.Combine(frontendFolder, fileToCopy);
                    string content = await File.ReadAllTextAsync(pathFile);
                    foreach (DataRow item in ds.Rows)
                    {
                        var nameTable = item["TableName"].ToString();
                        var data1 = Model.FindAfterName(nameTable).Value;

                        var newFileName = pathFile.Replace("@Name@", nameTable, StringComparison.InvariantCultureIgnoreCase);
                        var newContent = content.Replace("@Name@", nameTable, StringComparison.InvariantCultureIgnoreCase);
                        await File.WriteAllTextAsync(newFileName, newContent);

                    }
                    File.Delete(pathFile);
                }
                Console.WriteLine("in excel:" + data.DataToBeSentFurther.Count);
                var nrTablesExcel = data.DataToBeSentFurther.Count;


                var tableData = data.Metadata.Tables.First();
                logs.Add("reading files");
                var rec = new ReceiverFilesInFolder(f, "*.*", SearchOption.AllDirectories);
                data = await rec.TransformData(data);
                Console.WriteLine("after files:" + data.DataToBeSentFurther.Count);
                var razorTables = nameTablesToRender.Union(new[] { "DataSource" }).ToArray();
                logs.Add("razoring files");
                var t = new TransformerOneTableToMulti<SenderToRazorFromFile>("InputTemplate", "FullFileName", razorTables, new CtorDictionary());
                data = await t.TransformData(data);
                Console.WriteLine("after razor:" + data.DataToBeSentFurther.Count);
                logs.Add("consolidating output string");
                var one = new TransformerToOneTable("it=>it.StartsWith(\"OutputString\")");
                data = await one.TransformData(data);
                //Transformer
                //var outFile = new SenderOutputToFolder(@"C:\test\", false);
                Console.WriteLine("after one table string:" + data.DataToBeSentFurther.Count);
                logs.Add("consolidating output byte");
                one = new TransformerToOneTable("it=>it.StartsWith(\"OutputByte\")");
                data = await one.TransformData(data);
                Console.WriteLine("after one table byte:" + data.DataToBeSentFurther.Count);
                logs.Add("renaming");

                var ren = new TransformerRenameTable("it=>it.StartsWith(\"OutputString\")", "OutputString");
                data = await ren.TransformData(data);
                //SenderOutputToFolder
                //TransformerUpdateColumn
                //var up = new TransformerUpdateColumn("FullFileName_origin", data.DataToBeSentFurther[2].TableName, $"'{outputFolder}' + SUBSTRING(FullFileName_origin,{lenTemplateFolder+1},100)");
                Console.WriteLine(data.DataToBeSentFurther[3].TableName);
                var lenTemplateFolder = f.Length;
                var sep = Path.DirectorySeparatorChar;
                logs.Add("getting file names");

                var up = new TransformerUpdateColumn("FullFileName_origin", "OutputString", "'Generated" + sep + $"'+SUBSTRING(FullFileName_origin,{lenTemplateFolder + 2},100)");
                data = await up.TransformData(data);
                var x = data.DataToBeSentFurther;
                logs.Add("change column name=>key");

                var name = new ChangeColumnName("Name", "Key");

                data = await name.TransformData(data);
                logs.Add("change column origin=>name");
                name = new ChangeColumnName("FullFileName_origin", "Name");
                data = await name.TransformData(data);
                logs.Add("remove byte");

                var remByte = new FilterRemoveTable("OutputByte");
                data = await remByte.TransformData(data);
                logs.Add("saving to output");

                var save = new SenderOutputToFolder(outputFolder, false, "OutputString");
                data = await save.TransformData(data);
                logs.Add($"creating branch {g}");

                Console.WriteLine($"branch : {g} ");
                var b = await GitOps.CreateBranch(g);

                logs.Add($"sending data {g}");

                var final = await GitOps.CommitDir(b, outputFolder);
                logs.Add($"waiting {g}");

                var ret = await GitOps.waitForRuns(g);
                logs.Add($"success?  {ret}");

                //Console.WriteLine(string.Join(Environment.NewLine, ret));
                if (ret)
                {
                    var assets = await GitOps.FindAssetsInRelease(g);
                    if (assets.Length != 1)
                        return false;

                    var realAssets = assets.First().Assets;
                    logs.AddRange(realAssets.Select(it =>
                            it.Url + Environment.NewLine +
                        it.BrowserDownloadUrl + Environment.NewLine));

                }
            }
            catch(Exception ex)
            {
                
                logs.Add("ERROR!" + ex.Message);

                Directory.Delete(f, true);
                return false;
            }
            return true;


            
        }
        //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

    }
}
