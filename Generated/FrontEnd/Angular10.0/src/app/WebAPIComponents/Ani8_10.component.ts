import { Component, OnInit } from '@angular/core';
import{ Ani8_10 } from './../WebAPIClasses/Ani8_10';
import {Ani8_10Service} from './../services/Ani8_10.service';

@Component({
  selector: 'app-Ani8_10-component',
  templateUrl: './Ani8_10.component.html',
  styleUrls: ['./Ani8_10.component.css']
})
export class Ani8_10Component implements OnInit {

  public rows:Ani8_10[]=[];
  constructor(private mainService: Ani8_10Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
