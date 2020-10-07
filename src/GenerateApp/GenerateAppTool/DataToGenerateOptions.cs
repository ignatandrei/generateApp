using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace GenerateAppTool
{
    class DataToGenerateOptions
    {
        public DataToGenerateOptions()
        {
            var pathDll = Assembly.GetEntryAssembly().Location;

            folderWithTemplates = Path.GetDirectoryName(pathDll);
            folderWithTemplates = Path.Combine(folderWithTemplates, "GenerateAll");
            //folderWithTemplates = @"E:\ignatandrei\generateApp\src\GenerateApp\GenerateApp\wwwroot\GenerateAll";
            UnzipIfNeeded();
            outputFolder = Environment.CurrentDirectory;
            backEnd = "NETCore3.1";
            frontEnd = "Angular10.0";
        }

        private void UnzipIfNeeded()
        {
            var files = Directory.GetFiles(folderWithTemplates);
            if (files.Length != 1)
                return;

            ZipFile.ExtractToDirectory(files[0], folderWithTemplates);
            File.Delete(files[0]);
        }

        public string folderWithTemplates { get; set; }
        public string outputFolder { get; set; }
        public string backEnd { get; set; }
        public string frontEnd { get; set; }

        public string OutputToConsole()
        {
            var str = $"current options {Environment.NewLine}";
            str += $"{nameof(folderWithTemplates)}:{folderWithTemplates} {Environment.NewLine}";
            str += $"{nameof(outputFolder)}:{outputFolder}{Environment.NewLine}";
            str += $"{nameof(frontEnd)}:{frontEnd}{Environment.NewLine}";
            str += $"{nameof(backEnd)}:{backEnd}{Environment.NewLine}";

            return str;
        }
        //public string ToString(FormattableString formattable)
        //{
        //    var arguments = formattable.GetArguments()
        //                       .Select(arg => $"{arg.ToString()}").ToArray();

        //    return string.Format(formattable.Format, arguments);
        //}
        

    }
}
