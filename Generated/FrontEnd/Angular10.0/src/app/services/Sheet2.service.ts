import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ Sheet2 } from './../WebAPIClasses/Sheet2';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class Sheet2Service {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<Sheet2[]>{
    const url = this.baseUrl+'api/Sheet2/GetAll';
    
    return this.client.get<Sheet2[]>(url);
  }
  public Get(id:number):Observable<Sheet2>{
    const url = this.baseUrl+'api/Sheet2/Get/'+id;
    
    return this.client.get<Sheet2>(url);
  }
  public Update(data:Sheet2):Observable<Sheet2>{
    const url = this.baseUrl+'api/Sheet2/Put/'+data.id;
    
    return this.client.put<Sheet2>(url,data);
  }
  public Insert(data:Sheet2):Observable<Sheet2>{
    const url = this.baseUrl+'api/Sheet2/Insert/';
    
    return this.client.post<Sheet2>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/Sheet2/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
