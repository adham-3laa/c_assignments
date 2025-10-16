using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.Classes 
{
    public class DepartmentReposatory(AppDbContext _context) : GenaricRepository<Department>(_context), IDepartmentReposatory
    { 
    }
        
}
