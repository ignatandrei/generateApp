@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("Ani12_14").Value;
	var nameTable =dt.TableName;
}
import { Component, OnInit } from '@(angular)/core';
import{ @nameTable } from './../WebAPIClasses/@nameTable';
import {@(nameTable)Service} from './../services/@(nameTable).service';

@(Component)({
  selector: 'app-Ani12_14-component',
  templateUrl: './Ani12_14.component.html',
  styleUrls: ['./Ani12_14.component.css']
})
export class Ani12_14Component implements OnInit {

  public rows:@(nameTable)[]=[];
  constructor(private mainService: @(nameTable)Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
