@{
  var angular="@angular";
  var NgModule="@NgModule";
  string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}

  var ds= Model.FindAfterName("DataSource").Value;
    
    var nrRowsDS=ds.Rows.Count;
    
    var nameTablesToRender = new string[nrRowsDS];
    var tables=new System.Data.DataTable[nrRowsDS];
    for (int iRowDS = 0; iRowDS < nrRowsDS; iRowDS++)
    {
        var nameTable = ds.Rows[iRowDS]["TableName"].ToString();
        var renderTable = Model.FindAfterName(nameTable).Value;
        nameTablesToRender[iRowDS] = nameTable;
        tables[iRowDS]=renderTable;
    }
	string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
  string nameProperty(string original){
		return original.Replace(" ","").Replace("<","").Replace(">","").Replace("(","").Replace(")","").ToLower();
	}

}

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';


@foreach(var nameTable in nameTablesToRender){
	string nameClass=ClassNameFromTableName(nameTable);
<text>
import { @(nameClass)Component } from './WebAPIComponents/@(nameClass).component';

import { @(nameClass)AddComponent } from './WebAPIComponents/@(nameClass)add.component';

import { @(nameClass)EditComponent } from './WebAPIComponents/@(nameClass)edit.component';

</text>
}


const routes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
@foreach(var nameTable in nameTablesToRender){
	string nameClass=ClassNameFromTableName(nameTable);
<text>
{ path: '@(nameClass.ToLower())', component: @(nameClass)Component },

{ path: '@(nameClass.ToLower())/add', component: @(nameClass)AddComponent },

{ path: '@(nameClass.ToLower())/edit/:id', component: @(nameClass)EditComponent },

</text>
}
  

];

@(NgModule)({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
