
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { ValoriComponent } from './WebAPIComponents/Valori.component';

import { ValoriAddComponent } from './WebAPIComponents/Valoriadd.component';

import { ValoriEditComponent } from './WebAPIComponents/Valoriedit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'valori', component: ValoriComponent },

{ path: 'valori/add', component: ValoriAddComponent },

{ path: 'valori/edit/:id', component: ValoriEditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
