@model Stankins.Interfaces.IDataToSent
@{
	var Component = "@Component";
  var angular="@angular";
  var ds= Model.FindAfterName("DataSource").Value;    
  var nrRowsDS=ds.Rows.Count;

  string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
  }
  string services = "";
  for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
  {
    var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
    services+= ClassNameFromTableName(nameTable).ToLower() +":"+ ClassNameFromTableName(nameTable)+"Service";

  }

}
import { Component, OnInit } from '@(angular)/core';
@for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
{
  var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
<text>
import { @(nameTable)Service } from '../services/@(nameTable).service';
</text>

}
@(Component)({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  @for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
  {
    var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
  <text>
  public @("numberRecords"+ nameTable): number;
  </text>
  
  }
  
  constructor(private dep: dboDepartmentService) { }

  ngOnInit(): void {
    this.dep.Count().subscribe(it=> this.numberRecordsDep=it);
  }

}
