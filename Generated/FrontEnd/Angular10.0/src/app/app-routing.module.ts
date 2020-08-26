
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { csv20200826135839Component } from './WebAPIComponents/csv20200826135839.component';

import { csv20200826135839AddComponent } from './WebAPIComponents/csv20200826135839add.component';

import { csv20200826135839EditComponent } from './WebAPIComponents/csv20200826135839edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'csv20200826135839', component: csv20200826135839Component },

{ path: 'csv20200826135839/add', component: csv20200826135839AddComponent },

{ path: 'csv20200826135839/edit/:id', component: csv20200826135839EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
