using MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s;
using MVC_Sec_Project.Bll.Dto_s.EmployeeDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Services.Intrfaces
{
    public interface IEmployeeServices
    {
        public IEnumerable<EmployeeDto> GetAllEmployee();
        public EmployeeDetailsDto GetEmployeeById(int id);
        public int AddEmployee(CreatedEmployeeDto dto);
        public int UpdateEmployee(UpdatedEmployeeDto dto);
        public bool DeleteEmployee(int id);

    }
}
