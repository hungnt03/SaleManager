using Api.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Entities
{
    public interface IGenericRepository<T> where T : class
    {
        // Marks an entity as new
        T Add(T entity);

        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        T Delete(T entity);

        T Delete(int id);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // Get an entity by int id
        Task<T> GetSingleByIdAsync(int id);

        Task<T> GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        Task<IEnumerable<T>> GetAllAsync(string[] includes = null);

        Task<IEnumerable<T>> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IAsyncEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        Task<IEnumerable<T>> GetMany(Expression<Func<T, bool>> where, string includes);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);

        SecurityContext GetContext();
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private SecurityContext context;
        private readonly DbSet<T> dbSet;

        public GenericRepository(SecurityContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            return dbSet.Add(entity).Entity;
        }

        public virtual bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Count<T>(predicate) > 0;
        }

        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return dbSet.Count(where);
        }

        public virtual T Delete(T entity)
        {
            return dbSet.Remove(entity).Entity;
        }

        public virtual T Delete(int id)
        {
            var entity = dbSet.Find(id);
            return dbSet.Remove(entity).Entity;
        }

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return await query.ToListAsync();
            }
            return await context.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return await query.Where<T>(predicate).AsQueryable<T>().ToListAsync();
            }

            return await context.Set<T>().Where<T>(predicate).AsQueryable<T>().ToListAsync();
        }

        public virtual  IQueryable<T> GetMultiQueryable(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return  query.Where<T>(predicate).AsQueryable<T>();
            }
            return  context.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public virtual IAsyncEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            int skipCount = index * size;
            IQueryable<T> _resetSet;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = filter != null ? query.Where<T>(filter).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = filter != null ? context.Set<T>().Where<T>(filter).AsQueryable() : context.Set<T>().AsQueryable();
            }

            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsAsyncEnumerable();
        }

        public virtual async Task<T> GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault(expression);
            }
            return await context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public virtual async Task<T> GetSingleByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual async Task<IEnumerable<T>> GetMany(Expression<Func<T, bool>> where, string includes)
        {
            return await dbSet.Where(where).ToListAsync();
        }

        public SecurityContext GetContext()
        {
            return context;
        }
    }
}
