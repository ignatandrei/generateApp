import { Component, OnInit } from '@angular/core';
import{ Sheet2 } from './../WebAPIClasses/Sheet2';
import {Sheet2Service} from './../services/Sheet2.service';

@Component({
  selector: 'app-Sheet2-component',
  templateUrl: './Sheet2.component.html',
  styleUrls: ['./Sheet2.component.css']
})
export class Sheet2Component implements OnInit {

  public rows:Sheet2[]=[];
  constructor(private mainService: Sheet2Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
