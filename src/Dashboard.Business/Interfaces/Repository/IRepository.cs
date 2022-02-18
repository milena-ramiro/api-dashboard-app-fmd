using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dashboard.Business.Models;

namespace Dashboard.Business.Interfaces.Repository;

public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
{
    Task Add(TEntity entity);
    Task<TEntity> GetById(int id);
    Task<List<TEntity>> Get();
    Task Update(TEntity entity);
    Task Remove(int id);
    Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
    Task<int> SaveChanges();
}