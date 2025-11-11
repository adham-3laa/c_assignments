namespace MVC_Sec_Project.Bll.Services;
public interface IEmployeeService
{
    // Get , All , Update , Delete , Add

    Task<EmployeeDetailsResponse?> GetByIdAsync(int id);
    Task<IEnumerable<EmployeeResponse>> GetAllAsync();
    Task<IEnumerable<EmployeeResponse>> GetAllAsync(string name);

    Task<int> AddAsync(EmployeeRequest request);
    Task<int> UpdateAsync(EmployeeUpdateRequest request);
    Task<bool> DeleteAsync(int id);


}
