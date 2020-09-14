
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { OGChecklistv11Component } from './WebAPIComponents/OGChecklistv11.component';

import { OGChecklistv11AddComponent } from './WebAPIComponents/OGChecklistv11add.component';

import { OGChecklistv11EditComponent } from './WebAPIComponents/OGChecklistv11edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'ogchecklistv11', component: OGChecklistv11Component },

{ path: 'ogchecklistv11/add', component: OGChecklistv11AddComponent },

{ path: 'ogchecklistv11/edit/:id', component: OGChecklistv11EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
