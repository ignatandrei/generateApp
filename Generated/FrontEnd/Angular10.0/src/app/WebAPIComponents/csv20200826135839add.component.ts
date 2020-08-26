
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { csv20200826135839 } from '../WebAPIClasses/csv20200826135839';
import { csv20200826135839Service } from '../services/csv20200826135839.service';
@Component({
  selector: 'app-csv20200826135839add',
  templateUrl: './csv20200826135839add.component.html',
  styleUrls: ['./csv20200826135839add.component.css']
})
export class csv20200826135839AddComponent implements OnInit {

  public id: number;
  public dataToAdd: csv20200826135839;
  constructor( private router: Router, private mainService: csv20200826135839Service ) {

      this.dataToAdd = new csv20200826135839();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new csv20200826135839(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/csv20200826135839']);
  }


}
