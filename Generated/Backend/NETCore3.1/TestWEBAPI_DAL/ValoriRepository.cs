using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Valori_Repository : IRepository<Valori,long>
    {
        private readonly DatabaseContext databaseContext;

        public Valori_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Valori[]> GetAll()
        {
            return databaseContext.Valori.ToArrayAsync();
        }
        public Task<Valori> FindAfterId(long id)
        {
            var data = databaseContext.Valori.FirstOrDefaultAsync(it => it.id20200914041510 == id);
            return data;
        }
        public Task<Valori> FindSingle(Func<Valori ,bool> f)
        {
            var data = databaseContext.Valori.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Valori[]> FindMultiple(Func<Valori, bool> f)
        {
            var data = databaseContext.Valori.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Valori> Insert(Valori p)
        {
            databaseContext.Valori.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Valori> Update(Valori p)
        {
            var original = await FindAfterId(p.id20200914041510);
            if(original == null)
            {
                throw new ArgumentException("cannot found Valori  with id = {p.id20200914041510} ", nameof(p.id20200914041510));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Valori> Delete(Valori p)
        {
            var original = await FindAfterId(p.id20200914041510);
            databaseContext.Valori.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
