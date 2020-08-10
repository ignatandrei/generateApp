@model Stankins.Interfaces.IDataToSent
@{
	var angular="@angular";
	var Injectable = "@Injectable";
		var dt= Model.FindAfterName("Ani14").Value;
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

  
}
