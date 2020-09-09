import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ Sheet1 } from './../WebAPIClasses/Sheet1';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class Sheet1Service {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<Sheet1[]>{
    const url = this.baseUrl+'api/Sheet1/GetAll';
    
    return this.client.get<Sheet1[]>(url);
  }
  public Get(id:number):Observable<Sheet1>{
    const url = this.baseUrl+'api/Sheet1/Get/'+id;
    
    return this.client.get<Sheet1>(url);
  }
  public Update(data:Sheet1):Observable<Sheet1>{
    const url = this.baseUrl+'api/Sheet1/Put/'+data.id20200909002008;
    
    return this.client.put<Sheet1>(url,data);
  }
  public Insert(data:Sheet1):Observable<Sheet1>{
    const url = this.baseUrl+'api/Sheet1/Insert/';
    
    return this.client.post<Sheet1>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/Sheet1/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
