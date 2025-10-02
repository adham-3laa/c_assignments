using MVC_Sec_Project.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s
{
    public class DepartmentDetailsDto
    {
        public DepartmentDetailsDto(Department Department)
        {
            ID = Department.ID;
            Name = Department.Name;
            Code = Department.Code;
            Description = Department.Description;
            CreatedOn = DateOnly.FromDateTime(Department.CreatedOn);
            CreatedBy = Department.CreatedBy;
            LastModifiedOn = DateOnly.FromDateTime(Department.LastModifiedOn);
            LastModifiedBy = Department.LastModifiedBy;
            }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public int ID { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateOnly LastModifiedOn { get; set; }
    }
}
