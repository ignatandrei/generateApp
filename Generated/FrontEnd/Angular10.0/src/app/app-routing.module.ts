
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { EmployeesComponent } from './WebAPIComponents/Employees.component';

import { EmployeesAddComponent } from './WebAPIComponents/Employeesadd.component';

import { EmployeesEditComponent } from './WebAPIComponents/Employeesedit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'employees', component: EmployeesComponent },

{ path: 'employees/add', component: EmployeesAddComponent },

{ path: 'employees/edit/:id', component: EmployeesEditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
