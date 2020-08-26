
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { PropertySheet20032020Component } from './WebAPIComponents/PropertySheet20032020.component';

import { PropertySheet20032020AddComponent } from './WebAPIComponents/PropertySheet20032020add.component';

import { PropertySheet20032020EditComponent } from './WebAPIComponents/PropertySheet20032020edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'propertysheet20032020', component: PropertySheet20032020Component },

{ path: 'propertysheet20032020/add', component: PropertySheet20032020AddComponent },

{ path: 'propertysheet20032020/edit/:id', component: PropertySheet20032020EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
