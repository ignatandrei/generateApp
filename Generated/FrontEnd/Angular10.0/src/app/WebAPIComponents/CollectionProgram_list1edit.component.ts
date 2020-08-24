
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { CollectionProgram_list1 } from '../WebAPIClasses/CollectionProgram_list1';
import { CollectionProgram_list1Service } from '../services/CollectionProgram_list1.service';
@Component({
  selector: 'app-CollectionProgram_list1edit',
  templateUrl: './CollectionProgram_list1edit.component.html',
  styleUrls: ['./CollectionProgram_list1edit.component.css']
})
export class CollectionProgram_list1EditComponent implements OnInit {

  public id: number;
  public dataToEdit: CollectionProgram_list1;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: CollectionProgram_list1Service ) {

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
	const data=new CollectionProgram_list1(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/collectionprogram_list1']);
  }


}
