
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { CollectionProgram_list1Component } from './WebAPIComponents/CollectionProgram_list1.component';

import { CollectionProgram_list1AddComponent } from './WebAPIComponents/CollectionProgram_list1add.component';

import { CollectionProgram_list1EditComponent } from './WebAPIComponents/CollectionProgram_list1edit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'collectionprogram_list1', component: CollectionProgram_list1Component },

{ path: 'collectionprogram_list1/add', component: CollectionProgram_list1AddComponent },

{ path: 'collectionprogram_list1/edit/:id', component: CollectionProgram_list1EditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
