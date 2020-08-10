import { Component, OnInit } from '@angular/core';
import{ Ani12_14 } from './../WebAPIClasses/Ani12_14';
import {Ani12_14Service} from './../services/Ani12_14.service';

@Component({
  selector: 'app-Ani12_14-component',
  templateUrl: './Ani12_14.component.html',
  styleUrls: ['./Ani12_14.component.css']
})
export class Ani12_14Component implements OnInit {

  public rows:Ani12_14[]=[];
  constructor(private mainService: Ani12_14Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
