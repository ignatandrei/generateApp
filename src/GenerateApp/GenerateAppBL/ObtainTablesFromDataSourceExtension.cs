using MySqlConnector;
using Stankins.Excel;
using Stankins.MariaDB;
using StankinsObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace GenerateApp.Controllers
{
    public static class ObtainTablesFromDataSourceExtension
    {
        public async static Task<TablesFromDataSource> FromExcel(this string filePath)
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

        public async static Task<TablesFromDataSource> FromMariaDB(this string connection)
        {
            try
            {
                var recData = new ReceiveMetadataFromDatabaseMariaDB(connection);

                var data = await recData.TransformData(null);

                var tables = data.FindAfterName("tables").Value.Rows;
                var columns = data.FindAfterName("columns").Value.Rows;
                var nameTables = new List<Table>();
                foreach (DataRow dr in tables)
                {
                    var t = new Table();
                    t.name = dr["name"].ToString();
                    var id = dr["id"].ToString();
                    nameTables.Add(t);
                    foreach (DataRow item in columns)
                    {
                        if (item["tableId"].ToString() == id)
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
                res.error = connection + "!!!" + ex.Message + "!!" + ex.StackTrace;
                return res;
            }
        }


        public async static Task<TablesFromDataSource> FromPayloadConn(this PayLoadConn payLoadConn)
        {
            string connection = null;
            var ret = new TablesFromDataSource();
            ret.Success = false;
            var val = payLoadConn.connType;
            connTypes typeToLoad;
            try
            {
                typeToLoad = Enum.Parse<connTypes>(val, true);
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
                        if (int.TryParse(payLoadConn.connPort, out var port))
                        {
                            b.Port = (uint)port;
                        }
                        connection = b.ConnectionString;
                        return await connection.FromMariaDB() ;
                    //case connTypes.XLS:
                    //    var bytes = Convert.FromBase64String(payLoadConn.connFileContent);
                    //    var path = Path.Combine(
                    //              environment.WebRootPath,
                    //              payLoadConn.connFileName);
                    //    if (System.IO.File.Exists(path))
                    //        System.IO.File.Delete(path);



                    //    return await path.FromExcel();
                    default:
                        ret.error = $"{val} is not implemented yet";
                        return ret;
                }
            }
            catch (Exception ex)
            {
                ret.error = connection;
                ret.error += "!!!" + ex.Message + "!!!" + ex.StackTrace;
                return ret;
            }
        }
    }


}
