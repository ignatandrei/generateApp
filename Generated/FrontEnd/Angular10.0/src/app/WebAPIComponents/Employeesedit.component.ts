
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Employees } from '../WebAPIClasses/Employees';
import { EmployeesService } from '../services/Employees.service';
@Component({
  selector: 'app-Employeesedit',
  templateUrl: './Employeesedit.component.html',
  styleUrls: ['./Employeesedit.component.css']
})
export class EmployeesEditComponent implements OnInit {

  public id: number;
  public dataToEdit: Employees;
  constructor(private route: ActivatedRoute , private router: Router, private mainService: EmployeesService ) {

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
	const data=new Employees(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/employees']);
  }


}
