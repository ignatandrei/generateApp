import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import{ CollectionProgram_list1 } from './../WebAPIClasses/CollectionProgram_list1';
import {CollectionProgram_list1Service} from './../services/CollectionProgram_list1.service';

@Component({
  selector: 'app-CollectionProgram_list1-component',
  templateUrl: './CollectionProgram_list1.component.html',
  styleUrls: ['./CollectionProgram_list1.component.css']
})
export class CollectionProgram_list1Component implements OnInit {

  displayedColumns: string[] = ['rutadenumireruta','stare','camionnumarinmatriculare','recipientetotal','volumtotal','greutatetotala','datastart','timedatastart','timedatafinal', 'operations'];
  dataSource: MatTableDataSource<CollectionProgram_list1>;

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  

  public rows:CollectionProgram_list1[]=[];
  constructor(private mainService: CollectionProgram_list1Service, private router: Router ) { }

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
    this.router.navigate(["/collectionprogram_list1/add"]);
    return;
  }

}
