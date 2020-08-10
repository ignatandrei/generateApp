
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AboutComponent } from './about/about.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { APP_BASE_HREF, PlatformLocation } from '@angular/common';

import { Ani8_10Component } from './WebAPIComponents/Ani8_10.component';


import { Ani10_12Component } from './WebAPIComponents/Ani10_12.component';


import { Ani12_14Component } from './WebAPIComponents/Ani12_14.component';


import { Ani14Component } from './WebAPIComponents/Ani14.component';



@NgModule({
  declarations: [

		Ani8_10Component,
		
		Ani10_12Component,
		
		Ani12_14Component,
		
		Ani14Component,
		    AppComponent,
    NavbarComponent,
    AboutComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule
  ],
  providers: [{
    provide: APP_BASE_HREF,
    useFactory: (s: PlatformLocation) => s.getBaseHrefFromDOM(),
    deps: [PlatformLocation]
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
