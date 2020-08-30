import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import{ Employees } from './../WebAPIClasses/Employees';
import { APP_BASE_HREF } from '@angular/common';
@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  baseUrl: string;
  constructor(@Inject(APP_BASE_HREF) baseHref: string, private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl + baseHref ;
    console.log(environment.webAPIUrl );
    console.log(baseHref);
    console.log(this.baseUrl);
    

  }

  public GetAll() : Observable<Employees[]>{
    const url = this.baseUrl+'api/Employees/GetAll';
    
    return this.client.get<Employees[]>(url);
  }
  public Get(id:number):Observable<Employees>{
    const url = this.baseUrl+'api/Employees/Get/'+id;
    
    return this.client.get<Employees>(url);
  }
  public Update(data:Employees):Observable<Employees>{
    const url = this.baseUrl+'api/Employees/Put/'+data.id;
    
    return this.client.put<Employees>(url,data);
  }
  public Insert(data:Employees):Observable<Employees>{
    const url = this.baseUrl+'api/Employees/Insert/';
    
    return this.client.post<Employees>(url,data);
  }
  public Delete(id:number):Observable<number>{
    const url = this.baseUrl+'api/Employees/Delete/'+id;
    
    return this.client.delete<number>(url);
  }
  
}
