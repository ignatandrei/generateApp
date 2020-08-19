import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ Valori } from './../WebAPIClasses/Valori';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class ValoriService {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<Valori[]>{
    const url = this.baseUrl+'api/Valori/GetAll';
    
    return this.client.get<Valori[]>(url);
  }
  public Get(id:number):Observable<Valori>{
    const url = this.baseUrl+'api/Valori/Get/'+id;
    
    return this.client.get<Valori>(url);
  }
  public Update(data:Valori):Observable<Valori>{
    const url = this.baseUrl+'api/Valori/Put/'+data.id;
    
    return this.client.put<Valori>(url,data);
  }
  public Insert(data:Valori):Observable<Valori>{
    const url = this.baseUrl+'api/Valori/Insert/';
    
    return this.client.post<Valori>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/Valori/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
