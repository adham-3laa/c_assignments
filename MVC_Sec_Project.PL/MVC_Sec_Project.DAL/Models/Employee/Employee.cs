using MVC_Sec_Project.DAL.Models.Shared;
using MVC_Sec_Project.DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Models.Employee
{
    public class Employee :BaseEntity
    {
        public String Name { get; set; } = null!;
        public int Age { get; set; }
        public String? Address { get; set; }
        public Decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public DateTime HiringDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public virtual MVC_Sec_Project.DAL.Models.Department.Department? Department { get; set; }
        public int? DepartmentId { get; set; }



    }
}
