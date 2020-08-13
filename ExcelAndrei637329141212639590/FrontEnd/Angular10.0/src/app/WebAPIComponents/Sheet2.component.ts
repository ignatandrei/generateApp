@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("Sheet2").Value;
	var nameTable =dt.TableName;
}
import { Component, OnInit } from '@(angular)/core';
import{ @nameTable } from './../WebAPIClasses/@nameTable';
import {@(nameTable)Service} from './../services/@(nameTable).service';

@(Component)({
  selector: 'app-Sheet2-component',
  templateUrl: './Sheet2.component.html',
  styleUrls: ['./Sheet2.component.css']
})
export class Sheet2Component implements OnInit {

  public rows:@(nameTable)[]=[];
  constructor(private mainService: @(nameTable)Service ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

}
