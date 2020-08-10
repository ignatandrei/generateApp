import { Component, OnInit } from '@angular/core';
import{ Ani14 } from './../WebAPIClasses/Ani14';
import {Ani14Service} from './../services/Ani14.service';

@Component({
  selector: 'app-Ani14-component',
  templateUrl: './Ani14.component.html',
  styleUrls: ['./Ani14.component.css']
})
export class Ani14Component implements OnInit {

  public rows:Ani14[]=[];
  constructor(private mainService: Ani14Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
