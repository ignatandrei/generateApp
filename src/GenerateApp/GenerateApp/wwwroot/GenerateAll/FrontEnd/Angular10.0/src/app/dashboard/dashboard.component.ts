@{
	var Component = "@Component";
	var angular="@angular";
}
import { Component, OnInit } from '@(angular)/core';

@(Component)({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  public numberRecordsDep: number;
  constructor(private dep: dboDepartmentService) { }

  ngOnInit(): void {
    this.dep.Count().subscribe(it=> this.numberRecordsDep=it);
  }

}
