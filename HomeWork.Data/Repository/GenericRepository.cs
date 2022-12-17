using HomeWork.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.Data.Repository;
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    protected DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var data = await _dbSet.AddAsync(entity);

        await _context.SaveChangesAsync();

        return data.Entity;
    }

    public IQueryable<TEntity> GetAll()
        => _dbSet;

    public TEntity? GetById(int id)
        => _dbSet.Find(id);

    public TEntity? GetById(Guid id)
        => _dbSet.Find(id);

    public async Task<TEntity> Remove(TEntity entity)
    {
        var entry = _dbSet.Remove(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        var entry = _dbSet.Update(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }
}
