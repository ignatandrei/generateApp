@model Stankins.Interfaces.IDataToSent
@{
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
	
    var dt= Model.FindAfterName("@Name@").Value;
    var nameTable= dt.TableName;
    string nameClass= ClassNameFromTableName(nameTable);
    var dtOptions= Model.FindAfterName("@@Options@@").Value;

    var havePK = (dtOptions.Rows.Find(dt.TableName +"_PK") != null);
    string idTable ="", idType = "";
    if(havePK){
        idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();  
        idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
    }
	var nrCols =dt.Columns.Count;
	string nameProperty(string original, string nameClass){
		var name = original.ToLower().Replace(" ","").Replace("event","event1").Replace("class","class1").Replace("object","object1").Replace("<","").Replace("/","").Replace(">","").Replace("(","").Replace(")","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		if(nameClass.ToLower() == name)
            name= "generated_"+name;
		return name.Trim();
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
    string nameTypeForJS(string colTypeName){
		string nameType = "";
		switch(colTypeName.ToLower()){
				case "string":
                case "guid":
					nameType="DataTypes.STRING";
                    break;
                case "boolean":
                    nameType= "DataTypes.BOOLEAN";
                    break;
                case "byte[]"://https://developer.mozilla.org/en-US/docs/Web/JavaScript/Typed_arrays
                    nameType="DataTypes.BLOB";
                    break;
                case "byte":
                  nameType="DataTypes.BLOB";
                  break;
                case "datetime":
                    nameType = "DataTypes.Date";
                    break;
                case "single":
                case "double":
				        case "DataTypes.DECIMAL":
                case "int16":
                case "int32":
                case "int64":
                case "long":
					nameType="DataTypes.INTEGER";
					break;
				default:
					nameType="!!!!"+colTypeName;
					break;
			}
		return nameType;
	}
    
}
const {DataTypes} = require("sequelize");

let entity = null;
module.exports.@(nameClass)TestTable = (appConn, options, logger) => {
    try {
        if (!entity) {
            entity = appConn.define('@(nameClass)', {
                
                @(nameProperty(idTable,nameClass) ):{
                    type: @(nameTypeForJS(idType)),
                    allowNull: false,
                    primaryKey: true,                            
                }

                @for(int iCol = 0;iCol < nrCols; iCol++){
                    var col = dt.Columns[iCol];
                    var colType = col.DataType;
                    bool nullable=(col.AllowDBNull);
                    var colName= nameProperty(col.ColumnName,nameClass) ;
                    var nameType = nameTypeForJS(colType.Name);

                     if(colName == nameProperty(idTable,nameClass))
                            continue;
                    
                    <text>
                        , @(colName):{
                            type: @(nameType),
                            allowNull: @(nullable.ToString().ToLower()),
                            primaryKey: false,                            
                        }
                    </text>
                }

            // entity = appConn.define('test_table', {
            //     table_id: {
            //         type: DataTypes.INTEGER,
            //         allowNull: false,
            //         autoIncrement: true,
            //     },
            //     some_id: {
            //         type: DataTypes.STRING,
            //         allowNull: false,
            //         primaryKey: true,
            //         defaultValue: null
            //     },
            //     name: {
            //         type: DataTypes.STRING,
            //         allowNull: false,
            //         primaryKey: true,
            //         defaultValue: null
            //     },
            }, {
                schema: options && options.schema || '',
                updatedAt: 'updated_on',
                createdAt: 'inserted_on',
                freezeTableName: true,
                syncOnAssociation: true,
            });
        }
    }catch(ex){
        logger.error(ex);
    }finally {
        return entity;
    }
}
