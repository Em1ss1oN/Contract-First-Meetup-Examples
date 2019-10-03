import { Component, OnInit } from '@angular/core';
import {IncidentDto, IncidentsClient} from "../incidents-client/incidents-Client";
import {Observable} from "rxjs";
import {ActivatedRoute, ParamMap, Router} from "@angular/router";
import {switchMap} from "rxjs/operators";

@Component({
  selector: 'app-view-incident-component',
  templateUrl: './view-incident.component.html',
})
export class ViewIncidentComponent implements OnInit {
public Incident : Observable<IncidentDto>;

  constructor(private client: IncidentsClient,
              private route: ActivatedRoute,
              private router: Router ) {
  }

  ngOnInit() {
    this.Incident = this.route.paramMap.pipe(
      switchMap((params: ParamMap) =>
        this.client.get(params.get('id')))
    );
  }

}
