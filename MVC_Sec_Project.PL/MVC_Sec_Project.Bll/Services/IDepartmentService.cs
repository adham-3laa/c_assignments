using MVC_Sec_Project.Bll.DataTransferObjects.Departments;

namespace MVC_Sec_Project.Bll.Services;
public interface IDepartmentService
{
    Task<DepartmentDetailsResponse?> GetByIdAsync(int id);
    Task<IEnumerable<DepartmentResponse>> GetAllAsync();
    Task<int> CreateAsync(DepartmentRequest department);
    Task<int> UpdateAsync(DepartmentUpdateRequest department);
    Task<bool> DeleteAsync(int id);
}
