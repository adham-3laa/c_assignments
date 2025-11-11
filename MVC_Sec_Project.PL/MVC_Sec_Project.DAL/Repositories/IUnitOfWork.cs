namespace MVC_Sec_Project.DAL.Repositories;
public interface IUnitOfWork
{
    IEmployeeRepository Employees { get; }
    IDepartmentRepository Departments { get; }

    Task<int> SaveChangesAsync();
}
