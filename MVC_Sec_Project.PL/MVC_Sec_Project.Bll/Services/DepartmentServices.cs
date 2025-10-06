using MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s;
using MVC_Sec_Project.Bll.Factories.DepartmentFactory;
using MVC_Sec_Project.DAL.Reposatories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Services
{

    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentReposatory _reposatory;
        public DepartmentServices(IDepartmentReposatory reposatory)
        {
            _reposatory = reposatory;
        }
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var Departments = _reposatory.GetAll();
            //var MappedDepartments = Departments.Select(D => new DepartmentDto
            //{
            //    Id = D.ID,
            //    Name = D.Name,
            //    Code = D.Code,
            //    Description = D.Description
            //});
            List<DepartmentDto> MappedDepartments = new List<DepartmentDto>();
            foreach (var item in Departments)
            {
                var MappedDepartment = item.ToDepartmentDto();
                MappedDepartments.Add(MappedDepartment);


            }
            return MappedDepartments;

        }
        public DepartmentDetailsDto GetDepartmentById(int id)
        {
            var Department = _reposatory.GetById(id);
            if (Department is null) return null;
            else
            {
                //manual maping
                //var DepartmentToReturn = new DepartmentDetailsDto()
                //{
                //    ID = Department.ID,
                //    Name = Department.Name,
                //    Code = Department.Code,
                //    Description = Department.Description,
                //    CreatedOn = DateOnly.FromDateTime(Department.CreatedOn),
                //    CreatedBy = Department.CreatedBy,
                //    LastModifiedOn = DateOnly.FromDateTime(Department.LastModifiedOn),
                //    LastModifiedBy = Department.LastModifiedBy
                //};
                //constractor maping
                var DepartmentToReturn = Department.ToEntity();
                return DepartmentToReturn;

            }

}
        public int AddDepartment(CreatedDepartmentDto dto)
        {
            var Dept = dto.ToDepartment();
          return  _reposatory.Add(Dept);
        }
        public int UpdateDepartment(UpdateDepartmentDto dto)
        {
            var Dept = dto.FromUpdatedDepartment();
            return _reposatory.Update(Dept);
        }
        public int DeleteDepartment(int id) { 
            return _reposatory.Delete(id);

        }

        
    } 
}