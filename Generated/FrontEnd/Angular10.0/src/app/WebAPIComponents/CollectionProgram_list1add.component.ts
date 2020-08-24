
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { CollectionProgram_list1 } from '../WebAPIClasses/CollectionProgram_list1';
import { CollectionProgram_list1Service } from '../services/CollectionProgram_list1.service';
@Component({
  selector: 'app-CollectionProgram_list1add',
  templateUrl: './CollectionProgram_list1add.component.html',
  styleUrls: ['./CollectionProgram_list1add.component.css']
})
export class CollectionProgram_list1AddComponent implements OnInit {

  public id: number;
  public dataToAdd: CollectionProgram_list1;
  constructor( private router: Router, private mainService: CollectionProgram_list1Service ) {

      this.dataToAdd = new CollectionProgram_list1();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new CollectionProgram_list1(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/collectionprogram_list1']);
  }


}
