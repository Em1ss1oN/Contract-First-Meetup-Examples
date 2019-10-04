import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CreateIncidentComponent} from "./create-incident/create-incident.component";
import { ViewIncidentComponent } from "./view-incident-component/view-incident.component";
import {IncidentsClientModule} from "./incidents-client/incidents-client.module";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CreateIncidentComponent,
    ViewIncidentComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'create', component: CreateIncidentComponent },
      { path: 'view/:id', component: ViewIncidentComponent },
    ]),
    IncidentsClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
