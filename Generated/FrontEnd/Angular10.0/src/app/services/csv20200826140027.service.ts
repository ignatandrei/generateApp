import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ csv20200826140027 } from './../WebAPIClasses/csv20200826140027';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class csv20200826140027Service {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<csv20200826140027[]>{
    const url = this.baseUrl+'api/csv20200826140027/GetAll';
    
    return this.client.get<csv20200826140027[]>(url);
  }
  public Get(id:number):Observable<csv20200826140027>{
    const url = this.baseUrl+'api/csv20200826140027/Get/'+id;
    
    return this.client.get<csv20200826140027>(url);
  }
  public Update(data:csv20200826140027):Observable<csv20200826140027>{
    const url = this.baseUrl+'api/csv20200826140027/Put/'+data.id;
    
    return this.client.put<csv20200826140027>(url,data);
  }
  public Insert(data:csv20200826140027):Observable<csv20200826140027>{
    const url = this.baseUrl+'api/csv20200826140027/Insert/';
    
    return this.client.post<csv20200826140027>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/csv20200826140027/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
