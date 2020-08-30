@{
	var angular="@angular";
	var Component = "@Component";
	 string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}

	var dt= Model.FindAfterName("Employees").Value;
	var nameTable =dt.TableName;
	var nameClass = ClassNameFromTableName(nameTable);
	string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
  string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace(">","").Replace("(","").Replace(")","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		
		return name;
	}
	bool IsIdentifier(string text)
	{
     if (string.IsNullOrEmpty(text))
        return false;
     if (!char.IsLetter(text[0]) && text[0] != '_')
        return false;
     for (int ix = 1; ix < text.Length; ++ix)
        if (!char.IsLetterOrDigit(text[ix]) && text[ix] != '_')
           return false;
     return true;
	}
	
	
}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { @(nameClass) } from '../WebAPIClasses/@(nameClass)';
import { @(nameClass)Service } from '../services/@(nameClass).service';
@(Component)({
  selector: 'app-@(nameClass)add',
  templateUrl: './@(nameClass)add.component.html',
  styleUrls: ['./@(nameClass)add.component.css']
})
export class @(nameClass)AddComponent implements OnInit {

  public id: number;
  public dataToAdd: @(nameClass);
  constructor( private router: Router, private mainService: @(nameClass)Service ) {

      this.dataToAdd = new @(nameClass)();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new @(nameClass)(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/@(nameClass.ToLower())']);
  }


}
