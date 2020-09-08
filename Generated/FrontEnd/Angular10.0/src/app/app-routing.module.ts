
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { Sheet1Component } from './WebAPIComponents/Sheet1.component';

import { Sheet1AddComponent } from './WebAPIComponents/Sheet1add.component';

import { Sheet1EditComponent } from './WebAPIComponents/Sheet1edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'sheet1', component: Sheet1Component },

{ path: 'sheet1/add', component: Sheet1AddComponent },

{ path: 'sheet1/edit/:id', component: Sheet1EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
