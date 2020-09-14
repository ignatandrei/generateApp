import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ OGChecklistv11 } from './../WebAPIClasses/OGChecklistv11';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class OGChecklistv11Service {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<OGChecklistv11[]>{
    const url = this.baseUrl+'api/OGChecklistv11/GetAll';
    
    return this.client.get<OGChecklistv11[]>(url);
  }
  public Get(id:number):Observable<OGChecklistv11>{
    const url = this.baseUrl+'api/OGChecklistv11/Get/'+id;
    
    return this.client.get<OGChecklistv11>(url);
  }
  public Update(data:OGChecklistv11):Observable<OGChecklistv11>{
    const url = this.baseUrl+'api/OGChecklistv11/Put/'+data.id20200914033604;
    
    return this.client.put<OGChecklistv11>(url,data);
  }
  public Insert(data:OGChecklistv11):Observable<OGChecklistv11>{
    const url = this.baseUrl+'api/OGChecklistv11/Insert/';
    
    return this.client.post<OGChecklistv11>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/OGChecklistv11/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
