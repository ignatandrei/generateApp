@{
	var angular="@angular";
	var Component = "@Component";
	var dt= Model.FindAfterName("@Name@").Value;
	var nameTable =dt.TableName;
	string lowerCaseFirst(string s){
		return char.ToLower(s[0]) + s.Substring(1);
  }
  string nameProperty(string original){
		var name = original.Replace(" ","").ToLower();
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
import { @(nameTable) } from '../WebAPIClasses/@(nameTable)';
import { @(nameTable)Service } from '../services/@(nameTable).service';
@(Component)({
  selector: 'app-@(nameTable)add',
  templateUrl: './@(nameTable)add.component.html',
  styleUrls: ['./@(nameTable)add.component.css']
})
export class @(nameTable)AddComponent implements OnInit {

  public id: number;
  public dataToAdd: @(nameTable);
  constructor( private router: Router, private mainService: @(nameTable)Service ) {

      this.dataToAdd = new @(nameTable)();
   }

  ngOnInit(): void {
    
  }
  public add(): void{
	const data=new @(nameTable)(this.dataToAdd);
    this.mainService.Insert(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/@(nameTable.ToLower())']);
  }


}
