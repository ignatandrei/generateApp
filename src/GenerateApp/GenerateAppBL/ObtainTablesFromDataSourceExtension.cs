using Microsoft.AspNetCore.Server.Kestrel;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using Stankins.Excel;
using Stankins.MariaDB;
using Stankins.SqlServer;
using StankinsObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
        public async static Task<TablesFromDataSource> FromMSSQL(this string connection)
        {
            try
            {
                var recData = new ReceiveMetadataFromDatabaseSql(connection);

                var data = await recData.TransformData(null);

                var tables = data.FindAfterName("tables").Value.Rows;
                var columns = data.FindAfterName("columns").Value.Rows;
                var keys = data.FindAfterName("keys").Value;
                var nameTables = new List<Table>();
                foreach (DataRow dr in tables)
                {
                    var t = new Table();
                    t.name = dr["name"].ToString();
                    var id = dr["id"].ToString();
                    bool HasPK = false;
                    foreach (DataRow col in columns)
                    {
                        if (col["tableId"].ToString() != id)
                            continue;


                        var f = new Field();
                        f.name = col["name"].ToString();
                        f.originalType = col["type"].ToString();
                        foreach (DataRow row in keys.Rows)
                        {
                            if (row["type_desc"].ToString() != "PRIMARY_KEY_CONSTRAINT")
                                continue;

                            if (row["tableId"].ToString() != id.ToString())
                                continue;

                            if (row["column_id"].ToString() != col["id"].ToString())
                                continue;

                            f.IsPK = true;
                            HasPK = true;
                            continue;

                        }
                        t.fields.Add(f);

                    }
                    
                    if (HasPK)
                        nameTables.Add(t);
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

        public async static Task<TablesFromDataSource> FromMariaDB(this string connection)
        {
            try
            {
                var recData = new ReceiveMetadataFromDatabaseMariaDB(connection);

                var data = await recData.TransformData(null);

                var tables = data.FindAfterName("tables").Value.Rows;
                var columns = data.FindAfterName("columns").Value.Rows;
                var keys = data.FindAfterName("keys").Value;
                var nameTables = new List<Table>();
                foreach (DataRow dr in tables)
                {
                    var t = new Table();
                    t.name = dr["name"].ToString();
                    var id = dr["id"].ToString();
                    bool HasPK = false;
                    foreach (DataRow col in columns)
                    {
                        if (col["tableId"].ToString() == id)
                        {
                            var f = new Field();
                            f.name = col["name"].ToString();
                            f.originalType = col["type"].ToString();
                            foreach(DataRow row in keys.Rows)
                            {
                                if(col["id"] + ".PRIMARY" == row["id"].ToString())
                                {
                                    f.IsPK = true;
                                    HasPK = true;
                                    continue;
                                }
                            }
                            t.fields.Add(f);

                        }
                    }
                    if(HasPK)
                        nameTables.Add(t);
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
        public static string ConnectionString(this PayLoadConn payLoadConn)
        {
            
            var typeToLoad = Enum.Parse<connTypes>(payLoadConn.connType, true);
            
            switch (typeToLoad)
            {
                case connTypes.MARIADB:
                    {
                        var mariaDBConStr = new MySqlConnectionStringBuilder();
                        mariaDBConStr.Database = payLoadConn.connDatabase;
                        mariaDBConStr.Server = payLoadConn.connHost;
                        mariaDBConStr.UserID = payLoadConn.connUser;
                        mariaDBConStr.Password = payLoadConn.connPassword;
                        if (int.TryParse(payLoadConn.connPort, out var port))
                        {
                            mariaDBConStr.Port = (uint)port;
                        }
                        return mariaDBConStr.ConnectionString;
                    }
                case connTypes.MSSQL:
                    {
                        var sqlConStr = new SqlConnectionStringBuilder();
                        sqlConStr.DataSource = payLoadConn.connHost;
                        if (int.TryParse(payLoadConn.connPort, out var port))
                        {
                            sqlConStr.DataSource += ","+(uint)port;
                        }
                        sqlConStr.InitialCatalog = payLoadConn.connDatabase;
                        sqlConStr.UserID = payLoadConn.connUser;
                        sqlConStr.Password = payLoadConn.connPassword;
                        
                        return sqlConStr.ConnectionString;
                    }

                default:
                    throw new ArgumentException($"no connection for {typeToLoad}");

            }
        }

            public async static Task<TablesFromDataSource> FromPayloadConn(this PayLoadConn payLoadConn)
        {
            var ret = new TablesFromDataSource();
            ret.Success = false;
            string connection = null;
            var val = payLoadConn.connType;
            connTypes typeToLoad;
            try
            {
                typeToLoad = Enum.Parse<connTypes>(val, true);
            }
            catch
            {
                ret.error = $" cannot parse conn type {val} ";
                return ret;
            }
            try
            {
                    connection = payLoadConn.ConnectionString();
                switch (typeToLoad)
                {
                    case connTypes.MARIADB:
                        return await connection.FromMariaDB();
                    case connTypes.MSSQL:
                        return await connection.FromMSSQL();
                    default:
                        throw new ArgumentException($"not such {typeToLoad} ");
                }
                    
                    //case connTypes.XLS:
                    //    var bytes = Convert.FromBase64String(payLoadConn.connFileContent);
                    //    var path = Path.Combine(
                    //              environment.WebRootPath,
                    //              payLoadConn.connFileName);
                    //    if (System.IO.File.Exists(path))
                    //        System.IO.File.Delete(path);



                    //    return await path.FromExcel();
                    
                
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
