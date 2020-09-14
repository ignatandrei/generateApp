
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { OGChecklistv11 } from '../WebAPIClasses/OGChecklistv11';
import { OGChecklistv11Service } from '../services/OGChecklistv11.service';
@Component({
  selector: 'app-OGChecklistv11edit',
  templateUrl: './OGChecklistv11edit.component.html',
  styleUrls: ['./OGChecklistv11edit.component.css']
})
export class OGChecklistv11EditComponent implements OnInit {

  public id: number;
  public dataToEdit: OGChecklistv11;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: OGChecklistv11Service ) {

    // route.paramMap.subscribe(params=>{
    //   this.id = +params.get('id');
    // });

   }

  ngOnInit(): void {
    this.route.paramMap.pipe(
      tap(params => this.id = +params.get('id') ),
      switchMap(it => this.mainService.Get(this.id) ),
      delay(1000),
      tap(it => this.dataToEdit = it)
      )
  .subscribe();

  }
  public save(): void{
	const data=new OGChecklistv11(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/ogchecklistv11']);
  }


}
