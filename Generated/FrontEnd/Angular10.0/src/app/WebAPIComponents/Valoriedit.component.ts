
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Valori } from '../WebAPIClasses/Valori';
import { ValoriService } from '../services/Valori.service';
@Component({
  selector: 'app-Valoriedit',
  templateUrl: './Valoriedit.component.html',
  styleUrls: ['./Valoriedit.component.css']
})
export class ValoriEditComponent implements OnInit {

  public id: number;
  public dataToEdit: Valori;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: ValoriService ) {

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
	const data=new Valori(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/valori']);
  }


}
