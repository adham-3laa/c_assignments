using MVC_Sec_Project.DAL.Context;

namespace MVC_Sec_Project.DAL.Repositories;
public class DepartmentRepository(CompanyDbContext context) // Injection 
    : BaseRepository<Department>(context), IDepartmentRepository
{


}
