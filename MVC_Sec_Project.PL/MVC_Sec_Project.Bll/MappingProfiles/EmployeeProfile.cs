namespace MVC_Sec_Project.Bll.MappingProfiles;
internal class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<EmployeeRequest, Employee>();
        CreateMap<EmployeeUpdateRequest, Employee>();


        CreateMap<Employee, EmployeeDetailsResponse>()
                 .ForMember(d => d.Department,
            o => o.MapFrom(s => s.Department.Name));
        CreateMap<EmployeeDetailsResponse, EmployeeUpdateRequest>();
        CreateMap<Employee, EmployeeResponse>()
            .ForMember(d => d.Department,
            o => o.MapFrom(s => s.Department.Name));
        CreateMap<EmployeeUpdateRequest, EmployeeRequest>();

    }
}
