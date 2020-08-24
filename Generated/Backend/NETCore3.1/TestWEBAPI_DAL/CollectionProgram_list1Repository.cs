using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class CollectionProgram_list1_Repository : IRepository<CollectionProgram_list1>
    {
        private readonly DatabaseContext databaseContext;

        public CollectionProgram_list1_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<CollectionProgram_list1[]> GetAll()
        {
            return databaseContext.CollectionProgram_list1.ToArrayAsync();
        }
        public Task<CollectionProgram_list1> FindAfterId(long id)
        {
            var data = databaseContext.CollectionProgram_list1.FirstOrDefaultAsync(it => it.ID == id);
            return data;
        }
        public Task<CollectionProgram_list1> FindSingle(Func<CollectionProgram_list1 ,bool> f)
        {
            var data = databaseContext.CollectionProgram_list1.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<CollectionProgram_list1[]> FindMultiple(Func<CollectionProgram_list1, bool> f)
        {
            var data = databaseContext.CollectionProgram_list1.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<CollectionProgram_list1> Insert(CollectionProgram_list1 p)
        {
            databaseContext.CollectionProgram_list1.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<CollectionProgram_list1> Update(CollectionProgram_list1 p)
        {
            var original = await FindAfterId(p.ID);
            if(original == null)
            {
                throw new ArgumentException("cannot found CollectionProgram_list1  with id = {p.ID} ", nameof(p.ID));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<CollectionProgram_list1> Delete(CollectionProgram_list1 p)
        {
            var original = await FindAfterId(p.ID);
            databaseContext.CollectionProgram_list1.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
