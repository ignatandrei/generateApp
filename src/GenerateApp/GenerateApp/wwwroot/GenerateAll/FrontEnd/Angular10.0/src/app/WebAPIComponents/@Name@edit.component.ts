@{
	var angular="@angular";
	var Component = "@Component";
	
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
  string nameTypeForJS(string colTypeName){
		string nameType = "";
		switch(colTypeName.ToLower()){
				case "string":
					nameType="string";
					break;
				case "decimal":
        case "int32":
        case "int64":
					nameType="number";
					break;
				default:
					nameType="!!!!"+colTypeName;
					break;
			}
		return nameType;
  }
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


	var dt= Model.FindAfterName("@Name@").Value;
	var nameTable =dt.TableName;
  var nameClass = ClassNameFromTableName(nameTable);
  var dtOptions= Model.FindAfterName("@@Options@@").Value;
  var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
  idTable  =nameProperty(idTable);
  var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
  var nameType = nameTypeForJS(idType);

  string appender ="";
				if(nameType == "number")
					appender = "+";
                

}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { tap, delay, switchMapTo, switchMap } from 'rxjs/operators';
import { @(nameClass) } from '../WebAPIClasses/@(nameClass)';
import { @(nameClass)Service } from '../services/@(nameClass).service';
@(Component)({
  selector: 'app-@(nameClass)edit',
  templateUrl: './@(nameClass)edit.component.html',
  styleUrls: ['./@(nameClass)edit.component.css']
})
export class @(nameClass)EditComponent implements OnInit {

  public id: @(nameType);
  public dataToEdit: @(nameClass);
  constructor(private route: ActivatedRoute , private router: Router, private mainService: @(nameClass)Service ) {

    // route.paramMap.subscribe(params=>{
    //   this.id = +params.get('id');
    // });

   }

  ngOnInit(): void {
    this.route.paramMap.pipe(
      tap(params => this.id = @Raw(appender)params.get('id') ),
      switchMap(it => this.mainService.Get(this.id) ),
      delay(1000),
      tap(it => this.dataToEdit = it)
      )
  .subscribe();

  }
  public save(): void{
	const data=new @(nameClass)(this.dataToEdit);
    this.mainService.Update(data).subscribe(
      it => {
        window.alert('saved !');
      }
    );
  }
  public cancel(): void{
    this.router.navigate(['/@(nameClass.ToLower())']);
  }


}
