@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("@Name@").Value;
	var nameTable =dt.TableName;
}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { @(nameTable) } from '../WebAPIClasses/@(nameTable)';
import { @(nameTable)Service } from '../services/@(nameTable).service';
@(Component)({
  selector: 'app-@(nameTable)edit',
  templateUrl: './@(nameTable)edit.component.html',
  styleUrls: ['./@(nameTable)edit.component.css']
})
export class @(nameTable)EditComponent implements OnInit {

  public id: number;
  public dataToEdit: @(nameTable);
  constructor(private route: ActivatedRoute, private mainService: @(nameTable)Service ) {

    route.paramMap.subscribe(params=>{
      this.id = +params.get('id');
    });

   }

  ngOnInit(): void {
    this.mainService.Get(this.id).subscribe(it=>{
        this.dataToEdit = it;
    }) ;
    

  }

}
