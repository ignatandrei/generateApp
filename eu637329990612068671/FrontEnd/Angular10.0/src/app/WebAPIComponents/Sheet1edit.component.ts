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
  selector: 'app-@(nameTable)edit',
  templateUrl: './@(nameTable)edit.component.html',
  styleUrls: ['./@(nameTable)edit.component.css']
})
export class @(nameTable)EditComponent implements OnInit {

  public id: number;
  public dataToEdit: @(nameTable);
  constructor(private route: ActivatedRoute , private router: Router, private mainService: @(nameTable)Service ) {

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
    this.mainService.Update(this.dataToEdit).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/sheet1']);
  }


}
