
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { csv20200826140027 } from '../WebAPIClasses/csv20200826140027';
import { csv20200826140027Service } from '../services/csv20200826140027.service';
@Component({
  selector: 'app-csv20200826140027add',
  templateUrl: './csv20200826140027add.component.html',
  styleUrls: ['./csv20200826140027add.component.css']
})
export class csv20200826140027AddComponent implements OnInit {

  public id: number;
  public dataToAdd: csv20200826140027;
  constructor( private router: Router, private mainService: csv20200826140027Service ) {

      this.dataToAdd = new csv20200826140027();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new csv20200826140027(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/csv20200826140027']);
  }


}
