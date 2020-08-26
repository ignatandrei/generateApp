using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class csv20200826140027_Repository : IRepository<csv20200826140027>
    {
        private readonly DatabaseContext databaseContext;

        public csv20200826140027_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<csv20200826140027[]> GetAll()
        {
            return databaseContext.csv20200826140027.ToArrayAsync();
        }
        public Task<csv20200826140027> FindAfterId(long id)
        {
            var data = databaseContext.csv20200826140027.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<csv20200826140027> FindSingle(Func<csv20200826140027 ,bool> f)
        {
            var data = databaseContext.csv20200826140027.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<csv20200826140027[]> FindMultiple(Func<csv20200826140027, bool> f)
        {
            var data = databaseContext.csv20200826140027.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<csv20200826140027> Insert(csv20200826140027 p)
        {
            databaseContext.csv20200826140027.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<csv20200826140027> Update(csv20200826140027 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found csv20200826140027  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<csv20200826140027> Delete(csv20200826140027 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.csv20200826140027.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
