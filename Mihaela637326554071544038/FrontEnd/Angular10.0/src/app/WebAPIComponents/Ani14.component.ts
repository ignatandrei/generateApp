@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("Ani14").Value;
	var nameTable =dt.TableName;
}
import { Component, OnInit } from '@(angular)/core';
import{ @nameTable } from './../WebAPIClasses/@nameTable';
import {@(nameTable)Service} from './../services/@(nameTable).service';

@(Component)({
  selector: 'app-Ani14-component',
  templateUrl: './Ani14.component.html',
  styleUrls: ['./Ani14.component.css']
})
export class Ani14Component implements OnInit {

  public rows:@(nameTable)[]=[];
  constructor(private mainService: @(nameTable)Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
