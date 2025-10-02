using MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Services
{
    public interface IDepartmentServices
    {
        public IEnumerable<DepartmentDto> GetAllDepartments();
        public DepartmentDetailsDto GetDepartmentById(int id);
        public int AddDepartment(CreatedDepartmentDto dto);
        public int UpdateDepartment(UpdateDepartmentDto dto);
        public int DeleteDepartment(int id);

    }
}
