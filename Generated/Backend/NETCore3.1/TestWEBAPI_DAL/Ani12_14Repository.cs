using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Ani12_14_Repository : IRepository<Ani12_14>
    {
        private readonly DatabaseContext databaseContext;

        public Ani12_14_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Ani12_14[]> GetAll()
        {
            return databaseContext.Ani12_14.ToArrayAsync();
        }
        public Task<Ani12_14> FindAfterId(long id)
        {
            var data = databaseContext.Ani12_14.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<Ani12_14> FindSingle(Func<Ani12_14 ,bool> f)
        {
            var data = databaseContext.Ani12_14.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Ani12_14[]> FindMultiple(Func<Ani12_14, bool> f)
        {
            var data = databaseContext.Ani12_14.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Ani12_14> Insert(Ani12_14 p)
        {
            databaseContext.Ani12_14.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani12_14> Update(Ani12_14 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found Ani12_14  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani12_14> Delete(Ani12_14 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.Ani12_14.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
