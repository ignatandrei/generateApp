using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class PropertySheet20032020_Repository : IRepository<PropertySheet20032020>
    {
        private readonly DatabaseContext databaseContext;

        public PropertySheet20032020_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<PropertySheet20032020[]> GetAll()
        {
            return databaseContext.PropertySheet20032020.ToArrayAsync();
        }
        public Task<PropertySheet20032020> FindAfterId(long id)
        {
            var data = databaseContext.PropertySheet20032020.FirstOrDefaultAsync(it => it.id == id);
            return data;
        }
        public Task<PropertySheet20032020> FindSingle(Func<PropertySheet20032020 ,bool> f)
        {
            var data = databaseContext.PropertySheet20032020.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<PropertySheet20032020[]> FindMultiple(Func<PropertySheet20032020, bool> f)
        {
            var data = databaseContext.PropertySheet20032020.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<PropertySheet20032020> Insert(PropertySheet20032020 p)
        {
            databaseContext.PropertySheet20032020.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<PropertySheet20032020> Update(PropertySheet20032020 p)
        {
            var original = await FindAfterId(p.id);
            if(original == null)
            {
                throw new ArgumentException("cannot found PropertySheet20032020  with id = {p.id} ", nameof(p.id));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<PropertySheet20032020> Delete(PropertySheet20032020 p)
        {
            var original = await FindAfterId(p.id);
            databaseContext.PropertySheet20032020.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
