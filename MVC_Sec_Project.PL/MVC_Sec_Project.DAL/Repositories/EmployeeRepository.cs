using MVC_Sec_Project.DAL.Context;
using System.Linq.Expressions;

namespace MVC_Sec_Project.DAL.Repositories;
public class EmployeeRepository(CompanyDbContext context)
    : BaseRepository<Employee>(context), IEmployeeRepository
{

    public async Task<IEnumerable<Employee>> GetAllAsync(string name)
    {
        return await _dbSet.Where(x => x.Name == name).ToListAsync();
    }

    public async Task<IEnumerable<TResult>> GetAllAsync<TResult>(Expression<Func<Employee, TResult>> resultSelector)
    {
        return await _dbSet.Where(e => !e.IsDeleted)
            .Select(resultSelector).ToListAsync();
    }

    public IQueryable<Employee> GetAllAsQueryable()
    {
        return _dbSet.Where(e => !e.IsDeleted);
    }


}
