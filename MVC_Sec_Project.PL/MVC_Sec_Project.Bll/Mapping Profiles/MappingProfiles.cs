using AutoMapper;
using MVC_Sec_Project.Bll.Dto_s.EmployeeDto_s;
using MVC_Sec_Project.DAL.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Mapping_Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Gender, option => option.MapFrom(src => src.Gender))
                .ForMember(dest => dest.EmployeeType, option => option.MapFrom(src => src.EmployeeType))
                  .ForMember(dest => dest.Department, option => option.MapFrom(src => src.Department!=null ? src.Department.Name:null))

                .ReverseMap();
            CreateMap<Employee, EmployeeDetailsDto>()
                .ForMember(dest=>dest.Gender,option=>option.MapFrom(src=>src.Gender))
                .ForMember(dest => dest.EmployeeType, option => option.MapFrom(src => src.EmployeeType))
               .ForMember(dest => dest.HiringDate, option => option.MapFrom(src =>DateOnly.FromDateTime( src.HiringDate)))
                  .ForMember(dest => dest.Department, option => option.MapFrom(src => src.Department != null ? src.Department.Name : null))
                .ReverseMap();
            CreateMap< CreatedEmployeeDto, Employee>()
                               .ForMember(dest => dest.HiringDate, option => option.MapFrom(src =>src.HiringDate.ToDateTime(new TimeOnly())))

                .ReverseMap();
            CreateMap<UpdatedEmployeeDto, Employee>()
                            .ForMember(dest => dest.HiringDate, option => option.MapFrom(src => src.HiringDate.ToDateTime(new TimeOnly())))
                            .ReverseMap();



        }
    }
}
