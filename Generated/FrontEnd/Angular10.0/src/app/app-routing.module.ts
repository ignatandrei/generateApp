
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { Sheet1Component } from './WebAPIComponents/Sheet1.component';
import { Sheet1EditComponent } from './WebAPIComponents/Sheet1edit.component';


import { Sheet2Component } from './WebAPIComponents/Sheet2.component';
import { Sheet2EditComponent } from './WebAPIComponents/Sheet2edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'sheet1', component: Sheet1Component },
{ path: 'sheet1/edit/:id', component: Sheet1EditComponent },


{ path: 'sheet2', component: Sheet2Component },
{ path: 'sheet2/edit/:id', component: Sheet2EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
