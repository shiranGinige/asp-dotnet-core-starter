using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AspNetStarter.Models;

namespace AspNetStarter.Repositories
{
     public interface IGenericRepository<T> where T : Entity
    {
        Task<T> GetById(long id);
        Task<IEnumerable<T>> GetMultiple(string id, Expression<Func<T, bool>> specification);
        Task<IEnumerable<T>> GetAll();

        Task Add(T entity);
        Task Remove(T entity);
        Task Save();


    }
}