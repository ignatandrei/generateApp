
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { PropertySheet20032020 } from '../WebAPIClasses/PropertySheet20032020';
import { PropertySheet20032020Service } from '../services/PropertySheet20032020.service';
@Component({
  selector: 'app-PropertySheet20032020edit',
  templateUrl: './PropertySheet20032020edit.component.html',
  styleUrls: ['./PropertySheet20032020edit.component.css']
})
export class PropertySheet20032020EditComponent implements OnInit {

  public id: number;
  public dataToEdit: PropertySheet20032020;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: PropertySheet20032020Service ) {

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
	const data=new PropertySheet20032020(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/propertysheet20032020']);
  }


}
