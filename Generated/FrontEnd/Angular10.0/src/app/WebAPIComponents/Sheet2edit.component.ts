
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Sheet2 } from '../WebAPIClasses/Sheet2';
import { Sheet2Service } from '../services/Sheet2.service';
@Component({
  selector: 'app-Sheet2edit',
  templateUrl: './Sheet2edit.component.html',
  styleUrls: ['./Sheet2edit.component.css']
})
export class Sheet2EditComponent implements OnInit {

  public id: number;
  public dataToEdit: Sheet2;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: Sheet2Service ) {

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
    this.mainService.Update(this.dataToEdit).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/sheet1']);
  }


}
