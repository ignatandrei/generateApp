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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(name))
                yield return new ValidationResult($"{nameof(name)} is empty for field");

        }

        public string originalType;

    }
}
