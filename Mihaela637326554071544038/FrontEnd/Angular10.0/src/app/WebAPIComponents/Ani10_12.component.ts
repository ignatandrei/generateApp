@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("Ani10_12").Value;
	var nameTable =dt.TableName;
}
import { Component, OnInit } from '@(angular)/core';
import{ @nameTable } from './../WebAPIClasses/@nameTable';
import {@(nameTable)Service} from './../services/@(nameTable).service';

@(Component)({
  selector: 'app-Ani10_12-component',
  templateUrl: './Ani10_12.component.html',
  styleUrls: ['./Ani10_12.component.css']
})
export class Ani10_12Component implements OnInit {

  public rows:@(nameTable)[]=[];
  constructor(private mainService: @(nameTable)Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
