import { Component, OnInit } from '@angular/core';
import{ Sheet1 } from './../WebAPIClasses/Sheet1';
import {Sheet1Service} from './../services/Sheet1.service';

@Component({
  selector: 'app-Sheet1-component',
  templateUrl: './Sheet1.component.html',
  styleUrls: ['./Sheet1.component.css']
})
export class Sheet1Component implements OnInit {

  public rows:Sheet1[]=[];
  constructor(private mainService: Sheet1Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
