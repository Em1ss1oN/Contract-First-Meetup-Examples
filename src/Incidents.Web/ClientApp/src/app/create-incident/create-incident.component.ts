import {Component, OnInit} from '@angular/core';
import {IncidentModel, IncidentsClient, IncidentTlp, IncidentTypeDto} from "../incidents-client/incidents-Client";
import {Router} from "@angular/router";
import {NgForm} from "@angular/forms";

@Component({
  selector: 'app-create-incident',
  templateUrl: './create-incident.component.html',
})
export class CreateIncidentComponent implements OnInit {
  public Incident:IncidentModel;

  constructor(private client:IncidentsClient,
              private router:Router) {
    this.Incident = new IncidentModel({
      detected: new Date(),
      reporter: "",
      type: IncidentTypeDto.None,
      tlp: IncidentTlp.Red,
      description: "Description"
    });
  }

  ngOnInit() {
  }

  getTypes() {
    let types = [];
    for (let item in IncidentTypeDto) {
      if (isNaN(Number(item))) {
        types.push(item);
      }
    }

    return types;
  }

  getTlps() {
    let tlps = [];
    for (let item in IncidentTlp) {
      if (isNaN(Number(item))) {
        tlps.push(item);
      }
    }

    return tlps;
  }

  onSubmit(){
    this.client.create(this.Incident)
      .subscribe(objId => this.router.navigateByUrl("/view/" + objId.id), error =>  alert(error));
  }


}
