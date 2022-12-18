namespace HomeWork.Data.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class
{
    IQueryable<TEntity> GetAll();
    TEntity? GetById(Guid id);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> Remove(TEntity entity);
    Task<TEntity> Update(TEntity entity);
}