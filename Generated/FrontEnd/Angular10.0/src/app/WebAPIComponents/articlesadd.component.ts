
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { articles } from '../WebAPIClasses/articles';
import { articlesService } from '../services/articles.service';
@Component({
  selector: 'app-articlesadd',
  templateUrl: './articlesadd.component.html',
  styleUrls: ['./articlesadd.component.css']
})
export class articlesAddComponent implements OnInit {

  
  public dataToAdd: articles;
  constructor( private router: Router, private mainService: articlesService ) {

      this.dataToAdd = new articles();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new articles(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/articles']);
  }


}
