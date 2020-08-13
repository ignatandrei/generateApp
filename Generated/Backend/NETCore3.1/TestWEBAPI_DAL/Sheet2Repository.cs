using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class Sheet2_Repository : IRepository<Sheet2>
    {
        private readonly DatabaseContext databaseContext;

        public Sheet2_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<Sheet2[]> GetAll()
        {
            return databaseContext.Sheet2.ToArrayAsync();
        }
        public Task<Sheet2> FindAfterId(long id)
        {
            var data = databaseContext.Sheet2.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<Sheet2> FindSingle(Func<Sheet2 ,bool> f)
        {
            var data = databaseContext.Sheet2.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<Sheet2[]> FindMultiple(Func<Sheet2, bool> f)
        {
            var data = databaseContext.Sheet2.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<Sheet2> Insert(Sheet2 p)
        {
            databaseContext.Sheet2.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Sheet2> Update(Sheet2 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found Sheet2  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<Sheet2> Delete(Sheet2 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.Sheet2.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
