using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Omack.Data.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetById(int id);
        //void Add(TEntity entity);
        //void Update(TEntity entity);
        //void Delete(int id);
        //void Delete(Expression<Func<TEntity, bool>> where);
    }
}
