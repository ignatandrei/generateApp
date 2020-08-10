
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';



import { Sheet1Component } from './WebAPIComponents/Sheet1.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },

{ path: 'Sheet1', component: Sheet1Component },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
