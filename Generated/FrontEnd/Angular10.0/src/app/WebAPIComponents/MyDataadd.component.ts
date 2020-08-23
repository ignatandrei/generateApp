
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { MyData } from '../WebAPIClasses/MyData';
import { MyDataService } from '../services/MyData.service';
@Component({
  selector: 'app-MyDataadd',
  templateUrl: './MyDataadd.component.html',
  styleUrls: ['./MyDataadd.component.css']
})
export class MyDataAddComponent implements OnInit {

  public id: number;
  public dataToAdd: MyData;
  constructor( private router: Router, private mainService: MyDataService ) {

      this.dataToAdd = new MyData();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new MyData(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/mydata']);
  }


}
