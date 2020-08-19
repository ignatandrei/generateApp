using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Valori_Repository : IRepository<Valori>
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
            var data = databaseContext.Valori.FirstOrDefaultAsync(it => it.ID == id);
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
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found Valori  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Valori> Delete(Valori p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.Valori.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
