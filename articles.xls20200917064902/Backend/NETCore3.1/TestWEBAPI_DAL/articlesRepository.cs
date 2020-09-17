@model Stankins.Interfaces.IDataToSent
@{
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
    string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace(">","").Replace("(","").Replace(")","").ToLower();
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
    var dt= Model.FindAfterName("articles").Value;
    var dtOptions= Model.FindAfterName("@@Options@@").Value;
    var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
    var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  
    string repo= ClassNameFromTableName(dt.TableName)  + "_Repository";
	string nameClass= ClassNameFromTableName(dt.TableName);
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class @repo : IRepository<@(nameClass),@(idType)>
    {
        private readonly DatabaseContext databaseContext;

        public @repo (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<@(nameClass)[]> GetAll()
        {
            return databaseContext.@(nameClass).ToArrayAsync();
        }
        public Task<@(nameClass)> FindAfterId(@(idType) id)
        {
            var data = databaseContext.@(nameClass).FirstOrDefaultAsync(it => it.@(nameProperty(idTable)) == id);
            return data;
        }
        public Task<@(nameClass)> FindSingle(Func<@(nameClass) ,bool> f)
        {
            var data = databaseContext.@(nameClass).FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<@(nameClass)[]> FindMultiple(Func<@(nameClass), bool> f)
        {
            var data = databaseContext.@(nameClass).Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<@(nameClass)> Insert(@(nameClass) p)
        {
            databaseContext.@(nameClass).Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<@(nameClass)> Update(@(nameClass) p)
        {
            var original = await FindAfterId(p.@(nameProperty(idTable)));
            if(original == null)
            {
                throw new ArgumentException("cannot found @(nameClass)  with id = {p.@(nameProperty(idTable))} ", nameof(p.@(nameProperty(idTable))));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<@(nameClass)> Delete(@(nameClass) p)
        {
            var original = await FindAfterId(p.@(nameProperty(idTable)));
            databaseContext.@(nameClass).Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
