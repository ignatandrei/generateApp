
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { MyData } from '../WebAPIClasses/MyData';
import { MyDataService } from '../services/MyData.service';
@Component({
  selector: 'app-MyDataedit',
  templateUrl: './MyDataedit.component.html',
  styleUrls: ['./MyDataedit.component.css']
})
export class MyDataEditComponent implements OnInit {

  public id: number;
  public dataToEdit: MyData;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: MyDataService ) {

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
	const data=new MyData(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/mydata']);
  }


}
