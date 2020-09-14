using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class OGChecklistv11_Repository : IRepository<OGChecklistv11,long>
    {
        private readonly DatabaseContext databaseContext;

        public OGChecklistv11_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<OGChecklistv11[]> GetAll()
        {
            return databaseContext.OGChecklistv11.ToArrayAsync();
        }
        public Task<OGChecklistv11> FindAfterId(long id)
        {
            var data = databaseContext.OGChecklistv11.FirstOrDefaultAsync(it => it.id20200914033604 == id);
            return data;
        }
        public Task<OGChecklistv11> FindSingle(Func<OGChecklistv11 ,bool> f)
        {
            var data = databaseContext.OGChecklistv11.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<OGChecklistv11[]> FindMultiple(Func<OGChecklistv11, bool> f)
        {
            var data = databaseContext.OGChecklistv11.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<OGChecklistv11> Insert(OGChecklistv11 p)
        {
            databaseContext.OGChecklistv11.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<OGChecklistv11> Update(OGChecklistv11 p)
        {
            var original = await FindAfterId(p.id20200914033604);
            if(original == null)
            {
                throw new ArgumentException("cannot found OGChecklistv11  with id = {p.id20200914033604} ", nameof(p.id20200914033604));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<OGChecklistv11> Delete(OGChecklistv11 p)
        {
            var original = await FindAfterId(p.id20200914033604);
            databaseContext.OGChecklistv11.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
