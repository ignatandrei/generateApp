using System.Collections.Generic;

namespace GenerateApp.Controllers
{
    public class Table
    {
        public Table()
        {
            this.fields = new List<Field>();
        }
        public string name { get; set; }
        public List<Field> fields { get; set; }
    
    }
}
