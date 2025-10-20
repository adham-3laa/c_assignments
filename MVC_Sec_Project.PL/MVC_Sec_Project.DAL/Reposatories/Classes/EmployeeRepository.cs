using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Models;
using MVC_Sec_Project.DAL.Models.Employee;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.Classes
{
    public class EmployeeRepository(AppDbContext _context) : GenaricRepository<Employee>(_context),IEmployeeRepository
    {
    }
}
