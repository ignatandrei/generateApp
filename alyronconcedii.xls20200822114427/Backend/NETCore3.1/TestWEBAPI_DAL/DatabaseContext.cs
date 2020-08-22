@model Stankins.Interfaces.IDataToSent
@{

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
	string nameProperty(string original){
		var name = original.Replace(" ","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		
		return name;
	}
	//https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxfacts?view=roslyn-dotnet
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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
        @foreach(var nameTable in nameTablesToRender){
            <text>
            public virtual DbSet<@nameTable> @nameTable { get; set; }
            </text>
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        @foreach(var nameTable in nameTablesToRender){
         <text>
            modelBuilder.Entity<@nameTable>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         </text>
        }            

            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){

            @foreach(var dt in tables){
                var nrRows =dt.Rows.Count; 
                if(nrRows > 200)
                    nrRows=200;
                    
                var nrColumns = dt.Columns.Count;
                for(var iRow=0;iRow<nrRows;iRow++){
                    string text="";
                    for(var iCol=0;iCol<nrColumns;iCol++){
                        var column=dt.Columns[iCol];
                        string nameColumn = nameProperty(column.ColumnName);
                        var val =dt.Rows[iRow][iCol];
                        if(val == System.DBNull.Value)
                            val=null;
                        switch(column.DataType.Name.ToLower()){
                            case "string":
                                text+=", "+  nameColumn +" = " + "@\"" + (val??"") + "\"" ;
                                break;
                            case "int32":
                                text+=", "+  nameColumn +" = " +  (val??0)  ;
                                break;
                            case "decimal":
								text+=", "+  nameColumn +" = " +  (val??0) +"M" ;
                                break;
                            default:
                                text+=", "+ column.DataType.Name +"???"+ nameColumn +" = "+ val;  
                                break;  
                        };
                        
                    }
                    <text>
                    modelBuilder.Entity<@(dt.TableName)>().HasData(
                        new @(dt.TableName)(){ ID = @(iRow+1) @Raw(text) });
                    </text>
                }
            }

            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}