using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Ani14_Repository : IRepository<Ani14>
    {
        private readonly DatabaseContext databaseContext;

        public Ani14_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Ani14[]> GetAll()
        {
            return databaseContext.Ani14.ToArrayAsync();
        }
        public Task<Ani14> FindAfterId(long id)
        {
            var data = databaseContext.Ani14.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<Ani14> FindSingle(Func<Ani14 ,bool> f)
        {
            var data = databaseContext.Ani14.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Ani14[]> FindMultiple(Func<Ani14, bool> f)
        {
            var data = databaseContext.Ani14.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Ani14> Insert(Ani14 p)
        {
            databaseContext.Ani14.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani14> Update(Ani14 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found Ani14  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani14> Delete(Ani14 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.Ani14.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
