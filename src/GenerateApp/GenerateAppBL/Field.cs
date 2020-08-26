using System;

namespace GenerateApp.Controllers
{
    public class Field
    {
        public string name { get; set; }
        public string type
        {
            get
            {
                return generateType();
            }
        }
        private string generateType() =>
            originalType switch
            {
                null => "does not exist ",
                string s when s.Contains("int",StringComparison.InvariantCultureIgnoreCase) => "number",
                string s when s.Contains("varchar", StringComparison.InvariantCultureIgnoreCase) => "string",
                string s when s.Contains("bool", StringComparison.InvariantCultureIgnoreCase) => "boolean",
                string s when s.Contains("date", StringComparison.InvariantCultureIgnoreCase) => "date",

                _ => $"not found {originalType}"
            };

        public string originalType;

    }
}
