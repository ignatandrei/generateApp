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

  
}
