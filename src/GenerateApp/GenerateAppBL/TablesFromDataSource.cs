namespace GenerateApp.Controllers
{
    public class TablesFromDataSource
    {
        public bool Success { get; set; }
        public string error { get; set; }
        public Table[] tables { get; set; }
        public View[] views { get; set; }

        public Relations[] relations { get; set; }
    }
}
