import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import{ Sheet1 } from './../WebAPIClasses/Sheet1';

@Injectable({
  providedIn: 'root'
})
export class Sheet1Service {

  baseUrl: string;
  constructor(private client: HttpClient) { 
    this.baseUrl = environment.webAPIUrl;

  }

  public GetAll() : Observable<Sheet1[]>{
    const url = this.baseUrl+'api/Sheet1/GetAll';
    
    return this.client.get<Sheet1[]>(url);
  }

  
}
