using MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s;
using MVC_Sec_Project.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Factories.DepartmentFactory
{
    static class DepartmentFact
    {
        public static DepartmentDto ToDepartmentDto(this Department department)
        {
            return new DepartmentDto()
            { Code = department.Code,
                Name = department.Name,
                Id= department.ID,
                Description = department.Description
            
            };
        }
        public static DepartmentDetailsDto ToEntity(this Department D)
        {
            return new DepartmentDetailsDto(D);
        }
        public static Department ToDepartment(this CreatedDepartmentDto dto)
        {
            return new Department()
            {
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedBy = 1,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
                isDeleted = false
            };
        }
        public static Department FromUpdatedDepartment(this UpdateDepartmentDto dto)
        {
            return new Department()
            {   ID=dto.Id,
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.Now,
                isDeleted = false
            };
        }
    }
}
