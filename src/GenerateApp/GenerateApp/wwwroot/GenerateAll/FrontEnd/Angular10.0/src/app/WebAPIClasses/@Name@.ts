@model Stankins.Interfaces.IDataToSent
@{
string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
    }
    
   
    var dt= Model.FindAfterName("@Name@").Value;
    var dtOptions= Model.FindAfterName("@@Options@@").Value;
    var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
    var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
	idTable = nameProperty(idTable);
    var nrCols =dt.Columns.Count;
	string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
	}
	string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace(">","").Replace("(","").Replace(")","").ToLower();
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
                case "int32":
                case "int64":
                case "long":
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
                this.@(idTable)= other.@(idTable);
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
        public  @(idTable): @(nameTypeForJS(idType));
            
        @for(int iCol = 0;iCol < nrCols; iCol++){
            var col = dt.Columns[iCol];
            var colName= nameProperty(col.ColumnName) ;
            if(colName.ToLower() == idTable.ToLower())
                continue;
            var colType = col.DataType;
			var nameType = nameTypeForJS(colType.Name);
			

            <text>
            public @nameProperty(colName) : @nameType;
            </text>

        }
        
    }

	