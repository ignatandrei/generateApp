
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';



import { Ani8_10Component } from './WebAPIComponents/Ani8_10.component';


import { Ani10_12Component } from './WebAPIComponents/Ani10_12.component';


import { Ani12_14Component } from './WebAPIComponents/Ani12_14.component';


import { Ani14Component } from './WebAPIComponents/Ani14.component';



const routes: Routes = [
  { path: 'about', component: AboutComponent },

{ path: 'Ani8_10', component: Ani8_10Component },


{ path: 'Ani10_12', component: Ani10_12Component },


{ path: 'Ani12_14', component: Ani12_14Component },


{ path: 'Ani14', component: Ani14Component },

  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
