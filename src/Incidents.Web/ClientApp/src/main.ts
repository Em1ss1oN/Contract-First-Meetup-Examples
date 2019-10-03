import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';
import {BASE_URL as IncidentBaseUrl} from "./app/incidents-client/incidents-Client";

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}

export function getOrigin() {
  return document.location.origin;
}

const providers = [
  { provide: 'BASE_URL', useFactory: getBaseUrl, deps: [] },
  { provide: IncidentBaseUrl, useFactory: getOrigin, deps: []}
];

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic(providers).bootstrapModule(AppModule)
  .catch(err => console.log(err));
