
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { OGChecklistv11 } from '../WebAPIClasses/OGChecklistv11';
import { OGChecklistv11Service } from '../services/OGChecklistv11.service';
@Component({
  selector: 'app-OGChecklistv11add',
  templateUrl: './OGChecklistv11add.component.html',
  styleUrls: ['./OGChecklistv11add.component.css']
})
export class OGChecklistv11AddComponent implements OnInit {

  
  public dataToAdd: OGChecklistv11;
  constructor( private router: Router, private mainService: OGChecklistv11Service ) {

      this.dataToAdd = new OGChecklistv11();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new OGChecklistv11(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/ogchecklistv11']);
  }


}
