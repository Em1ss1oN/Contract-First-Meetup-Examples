import {Component, Inject} from '@angular/core';
import {IncidentListDto, IncidentsClient} from "../incidents-client/incidents-Client";
import {Observable} from "rxjs";


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public Incidents : Observable<IncidentListDto>;

  constructor(client : IncidentsClient, @Inject('BASE_URL') baseUrl: string){
    this.Incidents = client.getAll(100, 0)
  }
}
