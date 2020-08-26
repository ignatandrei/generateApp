
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { csv20200826140027Component } from './WebAPIComponents/csv20200826140027.component';

import { csv20200826140027AddComponent } from './WebAPIComponents/csv20200826140027add.component';

import { csv20200826140027EditComponent } from './WebAPIComponents/csv20200826140027edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'csv20200826140027', component: csv20200826140027Component },

{ path: 'csv20200826140027/add', component: csv20200826140027AddComponent },

{ path: 'csv20200826140027/edit/:id', component: csv20200826140027EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
