import { Component, OnInit } from '@angular/core';
import{ Ani10_12 } from './../WebAPIClasses/Ani10_12';
import {Ani10_12Service} from './../services/Ani10_12.service';

@Component({
  selector: 'app-Ani10_12-component',
  templateUrl: './Ani10_12.component.html',
  styleUrls: ['./Ani10_12.component.css']
})
export class Ani10_12Component implements OnInit {

  public rows:Ani10_12[]=[];
  constructor(private mainService: Ani10_12Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
