using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentReposatory _departmentReposatory;
        private readonly AppDbContext _context;
        public UnitOfWork(IEmployeeRepository employeeRepository,IDepartmentReposatory departmentReposatory, AppDbContext context)
        {
            _employeeRepository = employeeRepository;
            _departmentReposatory = departmentReposatory;
            _context = context;

        }
        public IEmployeeRepository EmployeeRepository => _employeeRepository;

        public IDepartmentReposatory DepartmentReposatory => _departmentReposatory;

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
