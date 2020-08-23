@model Stankins.Interfaces.IDataToSent
@{
string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","");
	}
    var dt= Model.FindAfterName("MyData").Value;
    var nrCols =dt.Columns.Count;
	string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
	}
	string nameProperty(string original){
		var name = original.Replace(" ","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		
		return name;
	}
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
	string nameTypeForJS(string colTypeName){
		string nameType = "";
		switch(colTypeName.ToLower()){
				case "string":
					nameType="string";
					break;
				case "decimal":
					nameType="number";
					break;
				default:
					nameType="!!!!"+colTypeName;
					break;
			}
		return nameType;
	}
	
	var nameClass= ClassNameFromTableName(dt.TableName);
}


export class @(nameClass)
    {
        
        
        public constructor(other:@(nameClass) = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:@(nameClass), withID: boolean):void{
            if(withID){
                this.id= other.id;
            }
            @for(int iCol = 0;iCol < nrCols; iCol++){
                var col = dt.Columns[iCol];
                var colName= nameProperty(col.ColumnName) ;
                var nameType = nameTypeForJS(col.DataType.Name);
				string appender ="";
				if(nameType == "number")
					appender = "+";
                <text>
            this.@lowerCaseFirst(colName) = @(Raw(appender))other.@lowerCaseFirst(colName);
                </text>

            }

            
        }
        public  id: number;
            
        @for(int iCol = 0;iCol < nrCols; iCol++){
            var col = dt.Columns[iCol];
            var colName= nameProperty(col.ColumnName) ;
            var colType = col.DataType;
			var nameType = nameTypeForJS(colType.Name);
			

            <text>
            public @lowerCaseFirst(colName) : @nameType;
            </text>

        }
        
    }

	