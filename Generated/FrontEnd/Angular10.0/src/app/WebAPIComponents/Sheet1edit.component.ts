
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Sheet1 } from '../WebAPIClasses/Sheet1';
import { Sheet1Service } from '../services/Sheet1.service';
@Component({
  selector: 'app-Sheet1edit',
  templateUrl: './Sheet1edit.component.html',
  styleUrls: ['./Sheet1edit.component.css']
})
export class Sheet1EditComponent implements OnInit {

  public id: number;
  public dataToEdit: Sheet1;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: Sheet1Service ) {

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
	const data=new Sheet1(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/sheet1']);
  }


}
