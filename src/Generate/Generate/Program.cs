﻿using Microsoft.Web.Administration;
using System;
using System.DirectoryServices;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Xml.Xsl;

namespace Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("https://docs.microsoft.com/en-us/previous-versions/iis/6.0-sdk/ms524896(v=vs.90)");
            //CreateVDir("IIS://Localhost/W3SVC/1/Root", "MyVDir", "E:\\Inetpub\\Wwwroot");
            var dir = Environment.CurrentDirectory;
            var fileName = Path.Combine(dir, "publish.zip");
            CreateVDir(fileName, @"C:\test");
        }
        /*
        static void CreateVDir(string metabasePath, string vDirName, string physicalPath)
        {
            //  metabasePath is of the form "IIS://<servername>/<service>/<siteID>/Root[/<vdir>]"
            //    for example "IIS://localhost/W3SVC/1/Root" 
            //  vDirName is of the form "<name>", for example, "MyNewVDir"
            //  physicalPath is of the form "<drive>:\<path>", for example, "C:\Inetpub\Wwwroot"
            Console.WriteLine("\nCreating virtual directory {0}/{1}, mapping the Root application to {2}:",
                metabasePath, vDirName, physicalPath);

            try
            {
                DirectoryEntry site = new DirectoryEntry(metabasePath);
                string className = site.SchemaClassName.ToString();
                if ((className.EndsWith("Server")) || (className.EndsWith("VirtualDir")))
                {
                    DirectoryEntries vdirs = site.Children;
                    DirectoryEntry newVDir = vdirs.Add(vDirName, (className.Replace("Service", "VirtualDir")));
                    newVDir.Properties["Path"][0] = physicalPath;
                    newVDir.Properties["AccessScript"][0] = true;
                    // These properties are necessary for an application to be created.
                    newVDir.Properties["AppFriendlyName"][0] = vDirName;
                    newVDir.Properties["AppIsolated"][0] = "1";
                    newVDir.Properties["AppRoot"][0] = "/LM" + metabasePath.Substring(metabasePath.IndexOf("/", ("IIS://".Length)));

                    newVDir.CommitChanges();

                    Console.WriteLine(" Done.");
                }
                else
                    Console.WriteLine(" Failed. A virtual directory can only be created in a site or virtual directory node.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed in CreateVDir with the following exception: \n{0}", ex.StackTrace);
            }
        }

        */
        static void CreateVDir(string zipFileName, string where)
        {
            var name = Path.GetFileNameWithoutExtension(zipFileName);
            
            ZipFile.ExtractToDirectory(zipFileName, where,true);
            string folder = Path.Combine(where, "publish");
            ServerManager manager = new ServerManager();
            Site defaultSite = manager.Sites["AppGenerator"];
            var appCreated = defaultSite.Applications.Add($"/{name}", folder);
            appCreated.ApplicationPoolName = "NETCore";
            manager.CommitChanges();
            return;
            foreach (Application app in defaultSite.Applications)
            {
                Console.WriteLine(
                    "Found application with the following path: {0}", app.Path);

                
                
                var vd = app.VirtualDirectories.Add($"/{name}",@$"D:\{name}");
                

                //Console.WriteLine("Virtual Directories:");
                //if (app.VirtualDirectories.Count > 0)
                //{
                //    foreach (VirtualDirectory vdir in app.VirtualDirectories)
                //    {
                //        Console.WriteLine(
                //            "  Virtual Directory: {0}", vdir.Path);
                //        Console.WriteLine(
                //            "   |-PhysicalPath = {0}", vdir.PhysicalPath);
                //        Console.WriteLine(
                //            "   |-LogonMethod  = {0}", vdir.LogonMethod);
                //        Console.WriteLine(
                //            "   +-UserName     = {0}\r\n", vdir.UserName);
                //    }
                //}
            }
            manager.CommitChanges();
        }


    }
}
