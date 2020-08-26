import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ PropertySheet20032020 } from './../WebAPIClasses/PropertySheet20032020';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class PropertySheet20032020Service {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<PropertySheet20032020[]>{
    const url = this.baseUrl+'api/PropertySheet20032020/GetAll';
    
    return this.client.get<PropertySheet20032020[]>(url);
  }
  public Get(id:number):Observable<PropertySheet20032020>{
    const url = this.baseUrl+'api/PropertySheet20032020/Get/'+id;
    
    return this.client.get<PropertySheet20032020>(url);
  }
  public Update(data:PropertySheet20032020):Observable<PropertySheet20032020>{
    const url = this.baseUrl+'api/PropertySheet20032020/Put/'+data.id;
    
    return this.client.put<PropertySheet20032020>(url,data);
  }
  public Insert(data:PropertySheet20032020):Observable<PropertySheet20032020>{
    const url = this.baseUrl+'api/PropertySheet20032020/Insert/';
    
    return this.client.post<PropertySheet20032020>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/PropertySheet20032020/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
