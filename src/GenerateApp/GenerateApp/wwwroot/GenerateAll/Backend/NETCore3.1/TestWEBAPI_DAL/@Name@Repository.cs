@model Stankins.Interfaces.IDataToSent
@{
	string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","");
	}
    var dt= Model.FindAfterName("@Name@").Value;
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
    public partial class @repo : IRepository<@(nameClass)>
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
        public Task<@(nameClass)> FindAfterId(long id)
        {
            var data = databaseContext.@(nameClass).FirstOrDefaultAsync(it => it.ID == id);
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
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found @(nameClass)  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<@(nameClass)> Delete(@(nameClass) p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.@(nameClass).Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
