
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { MyDataComponent } from './WebAPIComponents/MyData.component';

import { MyDataAddComponent } from './WebAPIComponents/MyDataadd.component';

import { MyDataEditComponent } from './WebAPIComponents/MyDataedit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'mydata', component: MyDataComponent },

{ path: 'mydata/add', component: MyDataAddComponent },

{ path: 'mydata/edit/:id', component: MyDataEditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
