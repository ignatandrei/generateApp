using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class csv20200826135839_Repository : IRepository<csv20200826135839>
    {
        private readonly DatabaseContext databaseContext;

        public csv20200826135839_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<csv20200826135839[]> GetAll()
        {
            return databaseContext.csv20200826135839.ToArrayAsync();
        }
        public Task<csv20200826135839> FindAfterId(long id)
        {
            var data = databaseContext.csv20200826135839.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<csv20200826135839> FindSingle(Func<csv20200826135839 ,bool> f)
        {
            var data = databaseContext.csv20200826135839.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<csv20200826135839[]> FindMultiple(Func<csv20200826135839, bool> f)
        {
            var data = databaseContext.csv20200826135839.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<csv20200826135839> Insert(csv20200826135839 p)
        {
            databaseContext.csv20200826135839.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<csv20200826135839> Update(csv20200826135839 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found csv20200826135839  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<csv20200826135839> Delete(csv20200826135839 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.csv20200826135839.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
