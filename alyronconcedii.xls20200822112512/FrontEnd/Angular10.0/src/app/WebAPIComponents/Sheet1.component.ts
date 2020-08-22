@{
	var angular="@angular";
  var Component = "@Component";
  var ViewChild="@ViewChild";
	var dt= Model.FindAfterName("Sheet1").Value;
  var nameTable =dt.TableName;
  var nrCols= dt.Columns.Count;
  

  string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
  string nameProperty(string original){
		var name = original.Replace(" ","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		
		return name;
	}
	bool IsIdentifier(string text)
	{
     if (string.IsNullOrEmpty(text))
        return false;
     if (!char.IsLetter(text[0]) && text[0] != '_')
        return false;
     for (int ix = 1; ix < text.Length; ++ix)
        if (!char.IsLetterOrDigit(text[ix]) && text[ix] != '_')
           return false;
     return true;
	}
	
	string colNames= "";
	for(int iCol = 0;iCol < nrCols; iCol++){
    var col = dt.Columns[iCol];
    colNames += "'"+ lowerCaseFirst(nameProperty(col.ColumnName)) +"',";
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
  selector: 'app-Sheet1-component',
  templateUrl: './Sheet1.component.html',
  styleUrls: ['./Sheet1.component.css']
})
export class Sheet1Component implements OnInit {

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
    this.router.navigate(["/@(lowerCaseFirst(nameProperty(nameTable)))/add"]);
    return;
  }

}
