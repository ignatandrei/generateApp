namespace GenerateApp.Controllers
{
    public class TablesFromDataSource
    {
        public bool Success { get; set; }
        public string error { get; set; }
        public Table[] input { get; set; }

        public Relations[] relations { get; set; }
    }
}
