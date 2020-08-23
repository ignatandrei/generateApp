import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ MyData } from './../WebAPIClasses/MyData';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class MyDataService {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<MyData[]>{
    const url = this.baseUrl+'api/MyData/GetAll';
    
    return this.client.get<MyData[]>(url);
  }
  public Get(id:number):Observable<MyData>{
    const url = this.baseUrl+'api/MyData/Get/'+id;
    
    return this.client.get<MyData>(url);
  }
  public Update(data:MyData):Observable<MyData>{
    const url = this.baseUrl+'api/MyData/Put/'+data.id;
    
    return this.client.put<MyData>(url,data);
  }
  public Insert(data:MyData):Observable<MyData>{
    const url = this.baseUrl+'api/MyData/Insert/';
    
    return this.client.post<MyData>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/MyData/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
