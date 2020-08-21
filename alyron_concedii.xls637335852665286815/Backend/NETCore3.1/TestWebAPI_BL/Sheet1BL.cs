@model Stankins.Interfaces.IDataToSent
@{

    var dt= Model.FindAfterName("Sheet1").Value;
    var nrCols =dt.Columns.Count;
	string nameProperty(string original){
		var name = original.Replace(" ","").ToLower();
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
    public partial class @(dt.TableName)
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(@dt.TableName other, bool withID);
        #endregion

        #region constructors
        public @dt.TableName (){
            OnConstructor();
        }
        
        public @(dt.TableName)(@dt.TableName other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(@dt.TableName other, bool withID){
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
