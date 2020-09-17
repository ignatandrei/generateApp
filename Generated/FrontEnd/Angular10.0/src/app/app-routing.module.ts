
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';



import { articlesComponent } from './WebAPIComponents/articles.component';

import { articlesAddComponent } from './WebAPIComponents/articlesadd.component';

import { articlesEditComponent } from './WebAPIComponents/articlesedit.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

{ path: 'articles', component: articlesComponent },

{ path: 'articles/add', component: articlesAddComponent },

{ path: 'articles/edit/:id', component: articlesEditComponent },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
