using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenerateApp.Controllers
{
    public class Field:IValidatableObject
    {
        public string name { get; set; }
        public string type
        {
            get
            {
                return generateType();
            }
        }
        public bool IsPK { get; set; }
        private string generateType() =>
            originalType?.ToLower() switch
            {
                null => "does not exist ",
                string s when s.Contains("int",StringComparison.InvariantCultureIgnoreCase) => "number",
                string s when s.Contains("varchar", StringComparison.InvariantCultureIgnoreCase) => "string",
                string s when s.Contains("bool", StringComparison.InvariantCultureIgnoreCase) => "boolean",
                string s when s.Contains("date", StringComparison.InvariantCultureIgnoreCase) => "date",

                _ => $"not found {originalType}"
            };
        public Type DotNetType() =>
            originalType?.ToLower() switch
            {
                null => null,
                string s when s.Contains("int", StringComparison.InvariantCultureIgnoreCase) => typeof(int),
                string s when s.Contains("varchar", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("bool", StringComparison.InvariantCultureIgnoreCase) => typeof(bool),
                string s when s.Contains("date", StringComparison.InvariantCultureIgnoreCase) => typeof(DateTime),

                _ => null
            };

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(name))
                yield return new ValidationResult($"{nameof(name)} is empty for field");

        }

        public string originalType;

    }
}
