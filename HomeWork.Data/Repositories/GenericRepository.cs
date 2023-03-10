using HomeWork.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.Data.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    protected DbSet<TEntity> DbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        DbSet = _context.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var entry = await DbSet.AddAsync(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public IQueryable<TEntity> GetAll()
        => DbSet;

    public TEntity? GetById(Guid id)
        => DbSet.Find(id);

    public async Task<TEntity> Remove(TEntity entity)
    {
        var entry = DbSet.Remove(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        var entry = DbSet.Update(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

}