namespace GenerateApp.Controllers
{
    public class PayLoadConn
    {
        public string connType { get; set; }
        public string connFileName { get; set; }
        public string connFileContent { get; set; }
        public string connHost { get; set; }
        public string connUser { get; set; }
        public string connPassword { get; set; }
        public string connDatabase { get; set; }

    }
    public enum connTypes
    {
        None = 0,
        XLS=1,
        SQLITE,
        SQLITEMEMO,
        MSSQL,
        MYSQL,
        MARIADB
            
    }
}