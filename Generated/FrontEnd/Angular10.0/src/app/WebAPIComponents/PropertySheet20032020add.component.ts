
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { PropertySheet20032020 } from '../WebAPIClasses/PropertySheet20032020';
import { PropertySheet20032020Service } from '../services/PropertySheet20032020.service';
@Component({
  selector: 'app-PropertySheet20032020add',
  templateUrl: './PropertySheet20032020add.component.html',
  styleUrls: ['./PropertySheet20032020add.component.css']
})
export class PropertySheet20032020AddComponent implements OnInit {

  public id: number;
  public dataToAdd: PropertySheet20032020;
  constructor( private router: Router, private mainService: PropertySheet20032020Service ) {

      this.dataToAdd = new PropertySheet20032020();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new PropertySheet20032020(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/propertysheet20032020']);
  }


}
