
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { csv20200826135839 } from '../WebAPIClasses/csv20200826135839';
import { csv20200826135839Service } from '../services/csv20200826135839.service';
@Component({
  selector: 'app-csv20200826135839edit',
  templateUrl: './csv20200826135839edit.component.html',
  styleUrls: ['./csv20200826135839edit.component.css']
})
export class csv20200826135839EditComponent implements OnInit {

  public id: number;
  public dataToEdit: csv20200826135839;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: csv20200826135839Service ) {

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
	const data=new csv20200826135839(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/csv20200826135839']);
  }


}
