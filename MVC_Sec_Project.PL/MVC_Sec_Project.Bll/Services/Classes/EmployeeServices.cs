using AutoMapper;
using MVC_Sec_Project.Bll.Dto_s.EmployeeDto_s;
using MVC_Sec_Project.Bll.Services.Intrfaces;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using MVC_Sec_Project.DAL.Models.Employee;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Services.Classes
{
    public class EmployeeServices(IEmployeeRepository reposatory,IMapper _mapper) : IEmployeeServices
    {
        
        public int AddEmployee(CreatedEmployeeDto dto)
        {
            var employee =_mapper.Map<Employee>(dto);
            return reposatory.Add(employee);
        }

        public bool DeleteEmployee(int id)
        {
            var employee=reposatory.GetById(id);
            if (employee is null) return false;
            else
            {
                employee.isDeleted = true;
                return reposatory.Update(employee)>0?true:false; 
            }

        }

        public IEnumerable<EmployeeDto> GetAllEmployee()
        {
            var employees = reposatory.GetAll();
            return _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            //var employees = reposatory.GetAll(e => new EmployeeDto()
            //{
            //    Id = e.ID,
            //    Name = e.Name,
            //    Salary = e.Salary,
            //    Age = e.Age
            //});//.Where(e => e.Age > 20);

            //return employees;


            #region GetIEnumerable
            //var result = reposatory.GetIEnumerable()
            //      .Where(e => e.isDeleted == false)
            //      .Select(e => new EmployeeDto()
            //      {
            //          Id = e.ID,
            //          Name = e.Name,
            //          Age = e.Age,
            //      });

            //Select * 
            //From [Employees] As [e] 
            #endregion

            #region GetIQueryable

            //var result = reposatory.GetIQueryable()
            //    .Where(e => e.isDeleted == false)
            //    .Select(e => new EmployeeDto()
            //    {
            //        Id = e.ID,
            //        Name = e.Name,
            //        Age = e.Age,
            //    });

            //Select [e].[Id] , [e].[Name] , [e].[Age]
            //EFrom [Employees] As [e]
            //Where [e].[isDeleted] = CAST(0 AS bit) 
            #endregion

            //return result.ToList();
        }

        public EmployeeDetailsDto GetEmployeeById(int id)
        {
            var employee = reposatory.GetById(id);
            if (employee == null) return null;
            var employeesDto = new EmployeeDetailsDto()
            {
                Id = employee.ID,
                Name = employee.Name,
                Age = employee.Age,
                Email = employee.Email,
                EmployeeType = employee.EmployeeType.ToString(),
                Gender = employee.Gender.ToString(),
                IsActive = employee.IsActive,
                Salary = employee.Salary,
                PhoneNumber= employee.PhoneNumber,
                CreatedBy= employee.CreatedBy,
                CreatedOn= employee.CreatedOn,
                HiringDate=DateOnly.FromDateTime( employee.HiringDate),
                LastModifiedBy= employee.LastModifiedBy,
                LastModifiedOn= employee.LastModifiedOn,
                Address= employee.Address
            };
            return employeesDto;
        }

        public int UpdateEmployee(UpdatedEmployeeDto dto)
        {
            var employee =_mapper.Map<Employee>(dto);
            return reposatory.Update(employee);
        }
    }
}
