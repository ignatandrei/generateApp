@model Stankins.Interfaces.IDataToSent
@{


	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
	
    var dt= Model.FindAfterName("@Name@").Value;
    string nameClass= ClassNameFromTableName(dt.TableName);
    var dtOptions= Model.FindAfterName("@@Options@@").Value;
    var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();  
    var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
	var nrCols =dt.Columns.Count;
	string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace("/","").Replace(">","").Replace("(","").Replace(")","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		
		return name;
	}
	//https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxfacts?view=roslyn-dotnet
	bool IsIdentifier(string text)
	{
     if (string.IsNullOrEmpty(text))
        return false;
     if (!char.IsLetter(text[0]) && text[0] != '_')
        return false;
     for (int ix = 1; ix < text.Length; ++ix)
        if (!char.IsLetterOrDigit(text[ix]) && text[ix] != '_')
           return false;
     return true;
	}
}
using System;

namespace TestWebAPI_BL
{
    public partial class @(nameClass)
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(@(nameClass) other, bool withID);
        #endregion

        #region constructors
        public @(nameClass) (){
            OnConstructor();
        }
        
        public @(nameClass)(@(nameClass) other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(@(nameClass) other, bool withID){
            if(withID){
                this.@(nameProperty(idTable))= other.@(nameProperty(idTable));
            }
            @for(int iCol = 0;iCol < nrCols; iCol++){
                var col = dt.Columns[iCol];
                var colName= nameProperty(col.ColumnName) ;
                 if(colName == nameProperty(idTable))
                        continue;
                
                <text>
            this.@colName = other.@colName;
                </text>

            }

            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public @(idType) @(nameProperty(idTable)){get;set;}
            
        @for(int iCol = 0;iCol < nrCols; iCol++){
            var col = dt.Columns[iCol];
            bool nullable=(col.AllowDBNull);
            var colName= nameProperty(col.ColumnName) ;
            var colType = col.DataType;
            if(colType.FullName == typeof(string).FullName)
                nullable=false;
             if(colName.ToLower() == idTable.ToLower())
                continue;
            <text>
            public @(colType.Name)@(nullable?"?":"") @(colName) { get; set; }
            </text>

        }
        #endregion
        
    }
}
