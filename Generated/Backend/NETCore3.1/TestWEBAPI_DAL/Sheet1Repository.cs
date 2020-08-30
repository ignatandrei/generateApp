using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Sheet1_Repository : IRepository<Sheet1>
    {
        private readonly DatabaseContext databaseContext;

        public Sheet1_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Sheet1[]> GetAll()
        {
            return databaseContext.Sheet1.ToArrayAsync();
        }
        public Task<Sheet1> FindAfterId(long id)
        {
            var data = databaseContext.Sheet1.FirstOrDefaultAsync(it => it.id == id);
            return data;
        }
        public Task<Sheet1> FindSingle(Func<Sheet1 ,bool> f)
        {
            var data = databaseContext.Sheet1.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Sheet1[]> FindMultiple(Func<Sheet1, bool> f)
        {
            var data = databaseContext.Sheet1.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Sheet1> Insert(Sheet1 p)
        {
            databaseContext.Sheet1.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Sheet1> Update(Sheet1 p)
        {
            var original = await FindAfterId(p.id);
            if(original == null)
            {
                throw new ArgumentException("cannot found Sheet1  with id = {p.id} ", nameof(p.id));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Sheet1> Delete(Sheet1 p)
        {
            var original = await FindAfterId(p.id);
            databaseContext.Sheet1.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
