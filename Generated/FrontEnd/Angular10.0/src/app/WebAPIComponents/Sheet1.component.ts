import { Component, OnInit } from '@angular/core';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import{ Sheet1 } from './../WebAPIClasses/Sheet1';
import {Sheet1Service} from './../services/Sheet1.service';

@Component({
  selector: 'app-Sheet1-component',
  templateUrl: './Sheet1.component.html',
  styleUrls: ['./Sheet1.component.css']
})
export class Sheet1Component implements OnInit {

  public rows:Sheet1[]=[];
  constructor(private mainService: Sheet1Service, private router: Router ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
		this.rows=it;
    })
  }

  public deleteData(id: number): void{

    this.mainService
    .Delete(id)
    .pipe(
      
      tap(idDeleted=>{
      const ndx = this.rows.findIndex(it=>it.id == idDeleted);
      this.rows.splice(ndx,1);
    })
    )
    .subscribe();
  }
  public add(): void{
    this.router.navigate(["/sheet1/add"]);
    return;
  }

}
