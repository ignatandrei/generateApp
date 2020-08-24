@model Stankins.Interfaces.IDataToSent
@{
	var angular="@angular";
	var Injectable = "@Injectable";
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace("(","").Replace(")","");
	}

		var dt= Model.FindAfterName("@Name@").Value;
    var nameTable =dt.TableName;
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
  public Get(id:number):Observable<@(nameClass)>{
    const url = this.baseUrl+'api/@(nameClass)/Get/'+id;
    
    return this.client.get<@(nameClass)>(url);
  }
  public Update(data:@(nameClass)):Observable<@(nameClass)>{
    const url = this.baseUrl+'api/@(nameClass)/Put/'+data.id;
    
    return this.client.put<@(nameClass)>(url,data);
  }
  public Insert(data:@(nameClass)):Observable<@(nameClass)>{
    const url = this.baseUrl+'api/@(nameClass)/Insert/';
    
    return this.client.post<@(nameClass)>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/@(nameClass)/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
