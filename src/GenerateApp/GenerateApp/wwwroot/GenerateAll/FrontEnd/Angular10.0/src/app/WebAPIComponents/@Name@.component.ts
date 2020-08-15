@{
	var angular="@angular";
  var Component = "@Component";
  var ViewChild="@ViewChild";
	var dt= Model.FindAfterName("@Name@").Value;
  var nameTable =dt.TableName;
  var nrCols= dt.Columns.Count;
  string colNames= "";
	for(int iCol = 0;iCol < nrCols; iCol++){
    var col = dt.Columns[iCol];
    colNames += "'"+ col.ColumnName +"',";
  }

  string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
  
}
import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import{ @nameTable } from './../WebAPIClasses/@nameTable';
import {@(nameTable)Service} from './../services/@(nameTable).service';

@(Component)({
  selector: 'app-@Name@-component',
  templateUrl: './@Name@.component.html',
  styleUrls: ['./@Name@.component.css']
})
export class @Name@Component implements OnInit {

  displayedColumns: string[] = [@Raw(colNames) 'operations'];
  dataSource: MatTableDataSource<@(nameTable)>;

  @(ViewChild)(MatPaginator, {static: true}) paginator: MatPaginator;
  @(ViewChild)(MatSort, {static: true}) sort: MatSort;

  

  public rows:@(nameTable)[]=[];
  constructor(private mainService: @(nameTable)Service, private router: Router ) { }

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
