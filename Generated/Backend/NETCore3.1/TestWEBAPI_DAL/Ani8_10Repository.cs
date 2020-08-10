using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Ani8_10_Repository : IRepository<Ani8_10>
    {
        private readonly DatabaseContext databaseContext;

        public Ani8_10_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Ani8_10[]> GetAll()
        {
            return databaseContext.Ani8_10.ToArrayAsync();
        }
        public Task<Ani8_10> FindAfterId(long id)
        {
            var data = databaseContext.Ani8_10.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<Ani8_10> FindSingle(Func<Ani8_10 ,bool> f)
        {
            var data = databaseContext.Ani8_10.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Ani8_10[]> FindMultiple(Func<Ani8_10, bool> f)
        {
            var data = databaseContext.Ani8_10.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Ani8_10> Insert(Ani8_10 p)
        {
            databaseContext.Ani8_10.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani8_10> Update(Ani8_10 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found Ani8_10  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani8_10> Delete(Ani8_10 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.Ani8_10.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
