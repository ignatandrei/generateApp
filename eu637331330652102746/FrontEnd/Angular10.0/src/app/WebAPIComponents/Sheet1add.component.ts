@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("Sheet1").Value;
	var nameTable =dt.TableName;
}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { @(nameTable) } from '../WebAPIClasses/@(nameTable)';
import { @(nameTable)Service } from '../services/@(nameTable).service';
@(Component)({
  selector: 'app-@(nameTable)add',
  templateUrl: './@(nameTable)add.component.html',
  styleUrls: ['./@(nameTable)add.component.css']
})
export class @(nameTable)AddComponent implements OnInit {

  public id: number;
  public dataToAdd: @(nameTable);
  constructor( private router: Router, private mainService: @(nameTable)Service ) {

      this.dataToAdd = new @(nameTable)();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
    this.mainService.Insert(this.dataToAdd).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/@(nameTable.ToLower())']);
  }


}
