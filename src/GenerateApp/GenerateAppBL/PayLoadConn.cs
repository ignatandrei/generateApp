using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenerateApp.Controllers
{
    public class GenerateAppV1
    {
        public PayLoadConn payLoadConn { get; set; }
        public TableGenerator[] input { get; set; }
    }
    public class TableGenerator
    {
        public Table table { get; set; }
        public CrudEndpoints crudEndpoints { get; set; }
    }
    public class CrudEndpoints: IValidatableObject
    {
        public bool List { get; set; }
        public bool Create { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Upsert { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Upsert)
            {
                if (Update || Create)
                    yield return new ValidationResult("cannot have create or update if upsert");


            }
            if(Update || Create)
            {
                if(Upsert)
                    yield return new ValidationResult("cannot have upsert if create or update ");

            }
        }
    }
    public class PayLoadConn
    {
        public string connType { get; set; }
        public string connFileName { get; set; }
        public string connFileContent { get; set; }
        public string connHost { get; set; }
        public string connUser { get; set; }
        public string connPassword { get; set; }
        public string connDatabase { get; set; }
        public string connPort { get; set; }

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