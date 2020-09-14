import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import{ OGChecklistv11 } from './../WebAPIClasses/OGChecklistv11';
import {OGChecklistv11Service} from './../services/OGChecklistv11.service';

@Component({
  selector: 'app-OGChecklistv11-component',
  templateUrl: './OGChecklistv11.component.html',
  styleUrls: ['./OGChecklistv11.component.css']
})
export class OGChecklistv11Component implements OnInit {

  displayedColumns: string[] = ['rowIndex' , 'ref','checklistquestion','fcanotes','obienotes','obie','psd2','cmaorder','generated_reg.references', 'operations'];
  dataSource: MatTableDataSource<OGChecklistv11>;

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  

  public rows:OGChecklistv11[]=[];
  constructor(private mainService: OGChecklistv11Service, private router: Router ) { }

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
      const ndx = this.rows.findIndex(it => it.id20200914033604 === idDeleted);
      this.dataSource.data.splice(ndx, 1);
      this.dataSource._updateChangeSubscription();
    })
    )
    .subscribe();
  }
  public add(): void{
    this.router.navigate(["/ogchecklistv11/add"]);
    return;
  }

}
