
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Valori } from '../WebAPIClasses/Valori';
import { ValoriService } from '../services/Valori.service';
@Component({
  selector: 'app-Valoriadd',
  templateUrl: './Valoriadd.component.html',
  styleUrls: ['./Valoriadd.component.css']
})
export class ValoriAddComponent implements OnInit {

  public id: number;
  public dataToAdd: Valori;
  constructor( private router: Router, private mainService: ValoriService ) {

      this.dataToAdd = new Valori();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new Valori(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/valori']);
  }


}
