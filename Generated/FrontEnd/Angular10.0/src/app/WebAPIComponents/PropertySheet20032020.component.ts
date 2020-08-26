import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import{ PropertySheet20032020 } from './../WebAPIClasses/PropertySheet20032020';
import {PropertySheet20032020Service} from './../services/PropertySheet20032020.service';

@Component({
  selector: 'app-PropertySheet20032020-component',
  templateUrl: './PropertySheet20032020.component.html',
  styleUrls: ['./PropertySheet20032020.component.css']
})
export class PropertySheet20032020Component implements OnInit {

  displayedColumns: string[] = ['address','column1','date','worktobeundertaken','column2','column3','column4', 'operations'];
  dataSource: MatTableDataSource<PropertySheet20032020>;

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  

  public rows:PropertySheet20032020[]=[];
  constructor(private mainService: PropertySheet20032020Service, private router: Router ) { }

  ngOnInit(): void {
	  this.mainService.GetAll().subscribe(it=>{
    this.rows=it;
    this.dataSource = new MatTableDataSource(it);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;

    });
  }
  public applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }


  public deleteData(id: number): void{

    if(!window.confirm("do you want to delete row "+ id)){
      return;
    }

    this.mainService
    .Delete(id)
    .pipe(
      
      tap(idDeleted=>{
    // const ndx = this.rows.findIndex(it=>it.id == idDeleted);
      // this.rows.splice(ndx,1);
      // this.dataSource = new MatTableDataSource(this.rows);
      const ndx = this.rows.findIndex(it => it.id === idDeleted);
      this.dataSource.data.splice(ndx, 1);
      this.dataSource._updateChangeSubscription();
    })
    )
    .subscribe();
  }
  public add(): void{
    this.router.navigate(["/propertysheet20032020/add"]);
    return;
  }

}
