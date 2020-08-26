@{
	var angular="@angular";
	var Component = "@Component";
	
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}

	var dt= Model.FindAfterName("@Name@").Value;
	var nameTable =dt.TableName;
	var nameClass = ClassNameFromTableName(nameTable);
}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { @(nameClass) } from '../WebAPIClasses/@(nameClass)';
import { @(nameClass)Service } from '../services/@(nameClass).service';
@(Component)({
  selector: 'app-@(nameClass)edit',
  templateUrl: './@(nameClass)edit.component.html',
  styleUrls: ['./@(nameClass)edit.component.css']
})
export class @(nameClass)EditComponent implements OnInit {

  public id: number;
  public dataToEdit: @(nameClass);
  constructor(private route: ActivatedRoute , private router: Router, private mainService: @(nameClass)Service ) {

    // route.paramMap.subscribe(params=>{
    //   this.id = +params.get('id');
    // });

   }

  ngOnInit(): void {
    this.route.paramMap.pipe(
      tap(params => this.id = +params.get('id')),
      switchMap(it => this.mainService.Get(this.id) ),
      delay(1000),
      tap(it => this.dataToEdit = it)
      )
  .subscribe();

  }
  public save(): void{
	const data=new @(nameClass)(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/@(nameClass.ToLower())']);
  }


}
