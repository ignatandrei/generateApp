using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Employees_Repository : IRepository<Employees>
    {
        private readonly DatabaseContext databaseContext;

        public Employees_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Employees[]> GetAll()
        {
            return databaseContext.Employees.ToArrayAsync();
        }
        public Task<Employees> FindAfterId(long id)
        {
            var data = databaseContext.Employees.FirstOrDefaultAsync(it => it.id == id);
            return data;
        }
        public Task<Employees> FindSingle(Func<Employees ,bool> f)
        {
            var data = databaseContext.Employees.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Employees[]> FindMultiple(Func<Employees, bool> f)
        {
            var data = databaseContext.Employees.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Employees> Insert(Employees p)
        {
            databaseContext.Employees.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Employees> Update(Employees p)
        {
            var original = await FindAfterId(p.id);
            if(original == null)
            {
                throw new ArgumentException("cannot found Employees  with id = {p.id} ", nameof(p.id));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Employees> Delete(Employees p)
        {
            var original = await FindAfterId(p.id);
            databaseContext.Employees.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
