using AdnRenting.Application.Interfaces;
using AdnRenting.Domain.Entities;
using AdnRenting.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdnRenting.Application.DataBase
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly AdnDBContext _dbContext;
        public Repository(AdnDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        public virtual async Task<IEnumerable<T>> List()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public virtual async Task<IEnumerable<T>> List(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>()
                   .Where(predicate)
                   .ToListAsync();
        }
        public async Task<T> Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.Entry(entity).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
