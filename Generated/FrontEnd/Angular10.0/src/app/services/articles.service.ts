import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ articles } from './../WebAPIClasses/articles';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class articlesService {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<articles[]>{
    const url = this.baseUrl+'api/articles/GetAll';
    
    return this.client.get<articles[]>(url);
  }
  public Get(id:number):Observable<articles>{
    const url = this.baseUrl+'api/articles/Get/'+id;
    
    return this.client.get<articles>(url);
  }
  public Update(data:articles):Observable<articles>{
    const url = this.baseUrl+'api/articles/Put/'+data.id20200916234906;
    
    return this.client.put<articles>(url,data);
  }
  public Insert(data:articles):Observable<articles>{
    const url = this.baseUrl+'api/articles/Insert/';
    
    return this.client.post<articles>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/articles/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
