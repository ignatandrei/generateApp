
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { articles } from '../WebAPIClasses/articles';
import { articlesService } from '../services/articles.service';
@Component({
  selector: 'app-articlesedit',
  templateUrl: './articlesedit.component.html',
  styleUrls: ['./articlesedit.component.css']
})
export class articlesEditComponent implements OnInit {

  public id: number;
  public dataToEdit: articles;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: articlesService ) {

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
	const data=new articles(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/articles']);
  }


}
