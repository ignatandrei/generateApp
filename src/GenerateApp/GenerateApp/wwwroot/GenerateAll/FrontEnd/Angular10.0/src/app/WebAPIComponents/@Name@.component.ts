@{
	var angular="@angular";
  var Component = "@Component";
  var ViewChild="@ViewChild";
  string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
	var dt= Model.FindAfterName("@Name@").Value;
  var nameTable =dt.TableName;
  var dtOptions= Model.FindAfterName("@@Options@@").Value;
  var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
  var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
  idTable = lowerCaseFirst(idTable);
  var nameClass = ClassNameFromTableName(nameTable);
  var nrCols= dt.Columns.Count;
  

  string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
  string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace("/","").Replace(">","").Replace("(","").Replace(")","").ToLower();
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

  string nameTypeForJS(string colTypeName){
		string nameType = "";
		switch(colTypeName.ToLower()){
				case "string":
					nameType="string";
					break;
				case "decimal":
        case "int32":
        case "int64":
        case "long":
					nameType="number";
					break;
				default:
					nameType="!!!!"+colTypeName;
					break;
			}
		return nameType;
	}

}
import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import{ @(nameClass) } from './../WebAPIClasses/@(nameClass)';
import {@(nameClass)Service} from './../services/@(nameClass).service';

@(Component)({
  selector: 'app-@(nameClass)-component',
  templateUrl: './@(nameClass).component.html',
  styleUrls: ['./@(nameClass).component.css']
})
export class @(nameClass)Component implements OnInit {

  displayedColumns: string[] = ['rowIndex' , @Raw(colNames) 'operations'];
  dataSource: MatTableDataSource<@(nameClass)>;

  @(ViewChild)(MatPaginator, {static: true}) paginator: MatPaginator;
  @(ViewChild)(MatSort, {static: true}) sort: MatSort;

  

  public rows:@(nameClass)[]=[];
  constructor(private mainService: @(nameClass)Service, private router: Router ) { }

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


  public deleteData(id: @(nameTypeForJS(idType))): void{

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
      const ndx = this.rows.findIndex(it => it.@nameProperty(idTable) === idDeleted);
      this.dataSource.data.splice(ndx, 1);
      this.dataSource._updateChangeSubscription();
    })
    )
    .subscribe();
  }
  public add(): void{
    this.router.navigate(["/@(nameClass.ToLower())/add"]);
    return;
  }

}
