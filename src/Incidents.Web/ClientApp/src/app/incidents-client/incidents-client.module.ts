import { NgModule} from "@angular/core";
import {HTTP_INTERCEPTORS, HttpClientModule} from "@angular/common/http";
import {IncidentsClient} from "./incidents-Client"

@NgModule({
  imports : [
    HttpClientModule
  ],
  providers: [
    IncidentsClient,
  ]
})
export class IncidentsClientModule {
}
