using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class MyData_Repository : IRepository<MyData>
    {
        private readonly DatabaseContext databaseContext;

        public MyData_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<MyData[]> GetAll()
        {
            return databaseContext.MyData.ToArrayAsync();
        }
        public Task<MyData> FindAfterId(long id)
        {
            var data = databaseContext.MyData.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<MyData> FindSingle(Func<MyData ,bool> f)
        {
            var data = databaseContext.MyData.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<MyData[]> FindMultiple(Func<MyData, bool> f)
        {
            var data = databaseContext.MyData.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<MyData> Insert(MyData p)
        {
            databaseContext.MyData.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<MyData> Update(MyData p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found MyData  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<MyData> Delete(MyData p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.MyData.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
