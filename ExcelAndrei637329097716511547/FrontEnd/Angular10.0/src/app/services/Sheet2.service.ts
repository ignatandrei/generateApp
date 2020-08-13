@model Stankins.Interfaces.IDataToSent
@{
	var angular="@angular";
	var Injectable = "@Injectable";
		var dt= Model.FindAfterName("Sheet2").Value;
    var nameTable =dt.TableName;
    var Inject=@"@Inject";
}
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ @nameTable } from './../WebAPIClasses/@nameTable';
import { APP_BASE_HREF } from '@angular/common';
@(Injectable)({
  providedIn: 'root'
})
export class @(nameTable)Service {

  baseUrl: string;
  constructor(@(Inject)(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<@(nameTable)[]>{
    const url = this.baseUrl+'api/@nameTable/GetAll';
    
    return this.client.get<@(nameTable)[]>(url);
  }
  public Get(id:number):Observable<@(nameTable)>{
    const url = this.baseUrl+'api/@(nameTable)/Get/'+id;
    
    return this.client.get<@(nameTable)>(url);
  }
  public Update(data:@(nameTable)):Observable<@(nameTable)>{
    const url = this.baseUrl+'api/@(nameTable)/Put/'+data.id;
    
    return this.client.put<@(nameTable)>(url,data);
  }
  public Insert(data:@(nameTable)):Observable<@(nameTable)>{
    const url = this.baseUrl+'api/@(nameTable)/Insert/';
    
    return this.client.post<@(nameTable)>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/@(nameTable)/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
