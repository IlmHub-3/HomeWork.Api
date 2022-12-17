using System.Linq.Expressions;

namespace HomeWork.Data.Repository;
public interface IGenericRepository<TEntity> where TEntity : class
{
    TEntity? GetById(int id);
    TEntity? GetById(Guid id);
    IQueryable<TEntity> GetAll();
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> Remove(TEntity entity);
    Task<TEntity> Update(TEntity entity);
}
