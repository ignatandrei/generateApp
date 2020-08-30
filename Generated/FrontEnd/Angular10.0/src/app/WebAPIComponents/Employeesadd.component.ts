
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { Employees } from '../WebAPIClasses/Employees';
import { EmployeesService } from '../services/Employees.service';
@Component({
  selector: 'app-Employeesadd',
  templateUrl: './Employeesadd.component.html',
  styleUrls: ['./Employeesadd.component.css']
})
export class EmployeesAddComponent implements OnInit {

  public id: number;
  public dataToAdd: Employees;
  constructor( private router: Router, private mainService: EmployeesService ) {

      this.dataToAdd = new Employees();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new Employees(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/employees']);
  }


}
