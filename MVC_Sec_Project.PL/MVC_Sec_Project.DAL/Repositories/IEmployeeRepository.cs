using System.Linq.Expressions;

namespace MVC_Sec_Project.DAL.Repositories;
public interface IEmployeeRepository : IRepository<Employee>
{
    Task<IEnumerable<Employee>> GetAllAsync(string name);
    IQueryable<Employee> GetAllAsQueryable();
    Task<IEnumerable<TResult>> GetAllAsync<TResult>(Expression<Func<Employee, TResult>> resultSelector);
}
