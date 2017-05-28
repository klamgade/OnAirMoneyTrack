using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using Omack.Data.DAL;

namespace Omack.Data.Infrastructure
{
    public abstract class GenericRepository<TEntity> where TEntity: class
    {
        private OmackContext context;
        private DbSet<TEntity> dbSet;

        public GenericRepository(OmackContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null )
        {
            IQueryable<TEntity> query = dbSet; 
            if(filter != null)
            {
                 query = query.Where(filter);
            }
            return query.ToList();
        }
        public TEntity GetById (int id)
        {
            return dbSet.Find(id);
        }         
    } 
}
