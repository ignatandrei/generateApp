@model Stankins.Interfaces.IDataToSent
@{


	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace("(","").Replace(")","");
	}
	
    var dt= Model.FindAfterName("@Name@").Value;
    string nameClass= ClassNameFromTableName(dt.TableName);
                
	var nrCols =dt.Columns.Count;
	string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace(">","").Replace("(","").Replace(")","").ToLower();
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
                this.ID= other.ID;
            }
            @for(int iCol = 0;iCol < nrCols; iCol++){
                var col = dt.Columns[iCol];
                var colName= nameProperty(col.ColumnName) ;
                
                <text>
            this.@colName = other.@colName;
                </text>

            }

            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            
        @for(int iCol = 0;iCol < nrCols; iCol++){
            var col = dt.Columns[iCol];
            var colName= nameProperty(col.ColumnName) ;
            var colType = col.DataType;

            <text>
            public @(colType.Name) @(colName) { get; set; }
            </text>

        }
        #endregion
        
    }
}
