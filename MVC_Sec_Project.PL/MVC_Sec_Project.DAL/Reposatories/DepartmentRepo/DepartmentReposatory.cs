using MVC_Sec_Project.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.DepartmentRepo 
{
    public class DepartmentReposatory : IDepartmentReposatory
    {
        private readonly AppDbContext _context;
        public DepartmentReposatory(AppDbContext context)
        { 
            _context = context;

        }

        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var department = _context.Departments.Find(id);
            _context.Departments.Remove(department);
            return _context.SaveChanges();

        }

        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
                return _context.Departments.ToList();
            else
                return _context.Departments.AsNoTracking().ToList();
        }

        public Department GetById(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }

        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }
        
    }
}
