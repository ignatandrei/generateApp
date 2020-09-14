import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainDashComponent } from './main-dash/main-dash.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: MainDashComponent },
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
