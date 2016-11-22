
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AspNetStarter.Data;
using AspNetStarter.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetStarter.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            Context = applicationDbContext;
        }

        public ApplicationDbContext Context { get; set; }
        public IQueryable<T> Vault => Context.Set<T>();

        public async Task<T> GetById(long id)
        {
            IQueryable<T> theSet = Context.Set<T>();
            return await theSet.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<T>> GetMultiple(string id, Expression<Func<T, bool>> specification)
        {
            IQueryable<T> theSet = Context.Set<T>();
            return await theSet.Where(specification).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IQueryable<T> theSet = Context.Set<T>();
            return await theSet.AsNoTracking().ToListAsync();
        }

        public async Task Add(T entity)
        {
            Context.Set<T>().Add(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Save()
        {
            await Context.SaveChangesAsync();
        }
    }
}