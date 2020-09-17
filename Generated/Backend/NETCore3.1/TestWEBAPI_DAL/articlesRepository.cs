using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TestWEBAPI_DAL;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class articles_Repository : IRepository<articles,long>
    {
        private readonly DatabaseContext databaseContext;

        public articles_Repository (DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Task<articles[]> GetAll()
        {
            return databaseContext.articles.ToArrayAsync();
        }
        public Task<articles> FindAfterId(long id)
        {
            var data = databaseContext.articles.FirstOrDefaultAsync(it => it.id20200916234906 == id);
            return data;
        }
        public Task<articles> FindSingle(Func<articles ,bool> f)
        {
            var data = databaseContext.articles.FirstOrDefaultAsync(it=>f(it));
            return data;
        }
        public Task<articles[]> FindMultiple(Func<articles, bool> f)
        {
            var data = databaseContext.articles.Where(it=>f(it));
            return data.ToArrayAsync();
        }
        public async Task<articles> Insert(articles p)
        {
            databaseContext.articles.Add(p);
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<articles> Update(articles p)
        {
            var original = await FindAfterId(p.id20200916234906);
            if(original == null)
            {
                throw new ArgumentException("cannot found articles  with id = {p.id20200916234906} ", nameof(p.id20200916234906));
            }
            original.CopyPropertiesFrom(other: p, withID: true);                        
            await databaseContext.SaveChangesAsync();
            return p;
        }
        public async Task<articles> Delete(articles p)
        {
            var original = await FindAfterId(p.id20200916234906);
            databaseContext.articles.Remove(original);
            await databaseContext.SaveChangesAsync();
            return p;
        }

    }
}
