using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Ani10_12_Repository : IRepository<Ani10_12>
    {
        private readonly DatabaseContext databaseContext;

        public Ani10_12_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Ani10_12[]> GetAll()
        {
            return databaseContext.Ani10_12.ToArrayAsync();
        }
        public Task<Ani10_12> FindAfterId(long id)
        {
            var data = databaseContext.Ani10_12.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<Ani10_12> FindSingle(Func<Ani10_12 ,bool> f)
        {
            var data = databaseContext.Ani10_12.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Ani10_12[]> FindMultiple(Func<Ani10_12, bool> f)
        {
            var data = databaseContext.Ani10_12.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Ani10_12> Insert(Ani10_12 p)
        {
            databaseContext.Ani10_12.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani10_12> Update(Ani10_12 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found Ani10_12  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Ani10_12> Delete(Ani10_12 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.Ani10_12.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
