using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace GenerateApp.Controllers
{
    public class Field:IValidatableObject
    {
        public Field()
        {
            IsNullable = false;
        }
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
        public Type DotNetType()
        {
            var t = DotNetTypeOriginal();
            if (!IsNullable)
                return t;
            if (t.FullName == typeof(string).FullName)
                return t;
            if (!t.IsValueType)
                return t;
            return typeof(Nullable<>).MakeGenericType(t);
        }
        private Type DotNetTypeOriginal() =>
            originalType?.ToLower() switch
            {
                null => null,
                string s when s.Contains("bit", StringComparison.InvariantCultureIgnoreCase) => typeof(bool),
                string s when s.Contains("bigint", StringComparison.InvariantCultureIgnoreCase) => typeof(long),
                string s when s.Contains("decimal", StringComparison.InvariantCultureIgnoreCase) => typeof(decimal),
                string s when s.Contains("numeric", StringComparison.InvariantCultureIgnoreCase) => typeof(double),
                string s when s.Contains("money", StringComparison.InvariantCultureIgnoreCase) => typeof(decimal),
                string s when s.Contains("float", StringComparison.InvariantCultureIgnoreCase) => typeof(float),
                string s when s.Contains("real", StringComparison.InvariantCultureIgnoreCase) => typeof(decimal),
                string s when s.Contains("time", StringComparison.InvariantCultureIgnoreCase) => typeof(DateTime),

                string s when s.Contains("uniqueidentifier", StringComparison.InvariantCultureIgnoreCase) => typeof(Guid),

                string s when s.Contains("int", StringComparison.InvariantCultureIgnoreCase) => typeof(int),
                string s when s.Contains("varchar", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("sql_variant", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("char", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("binary", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("text", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("xml", StringComparison.InvariantCultureIgnoreCase) => typeof(string),
                string s when s.Contains("image", StringComparison.InvariantCultureIgnoreCase) => typeof(byte[]),

                string s when s.Contains("bool", StringComparison.InvariantCultureIgnoreCase) => typeof(bool),
                string s when s.Contains("date", StringComparison.InvariantCultureIgnoreCase) => typeof(DateTime),

                _ => DefaultType(originalType?.ToLower())
            };
        public Type DefaultType(string name)
        {
            System.Diagnostics.Debug.Assert(false, $"cannot find {name}");
            return typeof(string);
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(name))
                yield return new ValidationResult($"{nameof(name)} is empty for field");

        }

        public string originalType;
        public bool IsNullable;
    }
}
