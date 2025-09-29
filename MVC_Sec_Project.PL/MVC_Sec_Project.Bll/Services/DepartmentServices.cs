using MVC_Sec_Project.DAL.Reposatories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Services
{
    
    public class DepartmentServices
    {
        private readonly IDepartmentReposatory _reposatory;
        public DepartmentServices(IDepartmentReposatory reposatory)
        {
          _reposatory = reposatory;
        }


    }
}
