
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Sheet1 } from '../WebAPIClasses/Sheet1';
import { Sheet1Service } from '../services/Sheet1.service';
@Component({
  selector: 'app-Sheet1add',
  templateUrl: './Sheet1add.component.html',
  styleUrls: ['./Sheet1add.component.css']
})
export class Sheet1AddComponent implements OnInit {

  
  public dataToAdd: Sheet1;
  constructor( private router: Router, private mainService: Sheet1Service ) {

      this.dataToAdd = new Sheet1();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new Sheet1(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/sheet1']);
  }


}
