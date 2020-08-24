import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ CollectionProgram_list1 } from './../WebAPIClasses/CollectionProgram_list1';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class CollectionProgram_list1Service {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<CollectionProgram_list1[]>{
    const url = this.baseUrl+'api/CollectionProgram_list1/GetAll';
    
    return this.client.get<CollectionProgram_list1[]>(url);
  }
  public Get(id:number):Observable<CollectionProgram_list1>{
    const url = this.baseUrl+'api/CollectionProgram_list1/Get/'+id;
    
    return this.client.get<CollectionProgram_list1>(url);
  }
  public Update(data:CollectionProgram_list1):Observable<CollectionProgram_list1>{
    const url = this.baseUrl+'api/CollectionProgram_list1/Put/'+data.id;
    
    return this.client.put<CollectionProgram_list1>(url,data);
  }
  public Insert(data:CollectionProgram_list1):Observable<CollectionProgram_list1>{
    const url = this.baseUrl+'api/CollectionProgram_list1/Insert/';
    
    return this.client.post<CollectionProgram_list1>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/CollectionProgram_list1/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
