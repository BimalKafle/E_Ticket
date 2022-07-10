using E_Ticketing.DataLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.DataLayer.Base
{
    public class BaseRepository<T> : BaseRepositoryInterface<T> where T : class
    {

        private readonly ApplicationDbContext DbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task Insert(T entity)
        {
           await DbContext.AddAsync(entity).ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await DbContext.Set<T>().ToListAsync().ConfigureAwait(false);
        }

        public async Task<T?> GetById(long id)
        {
            return await DbContext.Set<T>().FindAsync(id).ConfigureAwait(false);
        }

        public IQueryable<T> GetQueryable()
        {
            return DbContext.Set<T>();
        }

        public async Task Remove(T entity)
        {
            await Task.Run(() => DbContext.Set<T>().Remove(entity)).ConfigureAwait(false);
        }

        public async Task Update(T entity)
        {
            EntityEntry entry = DbContext.Entry<T>(entity);
            entry.State = EntityState.Modified;
        }
    }
}
