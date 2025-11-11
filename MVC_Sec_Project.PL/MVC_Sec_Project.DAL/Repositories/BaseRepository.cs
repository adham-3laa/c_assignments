using MVC_Sec_Project.DAL.Context;

namespace MVC_Sec_Project.DAL.Repositories;
public class BaseRepository<TEntity>(CompanyDbContext context) : IRepository<TEntity> where TEntity : BaseEntity
{
    protected DbSet<TEntity> _dbSet = context.Set<TEntity>();
    public virtual void Add(TEntity TEntity)
    {
        _dbSet.Add(TEntity);
    }

    public virtual void Delete(TEntity TEntity)
    {
        TEntity.IsDeleted = true;
        _dbSet.Update(TEntity);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges = false)
        =>
        trackChanges ?
       await _dbSet
        .Where(x => !x.IsDeleted)
        .ToListAsync()
        : await _dbSet
        .AsNoTracking()
        .Where(x => !x.IsDeleted)
        .ToListAsync();
    public virtual async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual void Update(TEntity TEntity)
    {
        _dbSet.Update(TEntity);
    }
}
