@model Stankins.Interfaces.IDataToSent
@{
	var angular="@angular";
	var Injectable = "@Injectable";
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
  string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
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

		var dt= Model.FindAfterName("Valori").Value;
    var nameTable =dt.TableName;
    var dtOptions= Model.FindAfterName("@@Options@@").Value;
    var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
    idTable  =nameProperty(idTable);
    var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
    idType = nameTypeForJS(idType);
	var nameClass= ClassNameFromTableName(nameTable);
    var Inject=@"@Inject";
}
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ @nameClass } from './../WebAPIClasses/@nameClass';
import { APP_BASE_HREF } from '@angular/common';
@(Injectable)({
  providedIn: 'root'
})
export class @(nameClass)Service {

  baseUrl: string;
  constructor(@(Inject)(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<@(nameClass)[]>{
    const url = this.baseUrl+'api/@nameClass/GetAll';
    
    return this.client.get<@(nameClass)[]>(url);
  }
  public Get(id:@(idType)):Observable<@(nameClass)>{
    const url = this.baseUrl+'api/@(nameClass)/Get/'+id;
    
    return this.client.get<@(nameClass)>(url);
  }
  public Update(data:@(nameClass)):Observable<@(nameClass)>{
    const url = this.baseUrl+'api/@(nameClass)/Put/'+data.@(nameProperty(idTable));
    
    return this.client.put<@(nameClass)>(url,data);
  }
  public Insert(data:@(nameClass)):Observable<@(nameClass)>{
    const url = this.baseUrl+'api/@(nameClass)/Insert/';
    
    return this.client.post<@(nameClass)>(url,data);
  }
  public Delete(id:@(idType)):Observable<@(idType)>{
    const url = this.baseUrl+'api/@(nameClass)/Delete/'+id;
    
    return this.client.delete<@(idType)>(url);
  }
  
}
