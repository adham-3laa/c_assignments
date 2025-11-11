
namespace MVC_Sec_Project.Bll.Services;
public class EmployeeService(IUnitOfWork unitOfWork, IMapper mapper, IDocumentService documentService)
    : IEmployeeService
{

    public async Task<int> AddAsync(EmployeeRequest request)
    {
        var employee = mapper.Map<EmployeeRequest, Employee>(request);
        if (request.Image != null && request.Image.Length > 0)
        {
            var imageName = await documentService.UploadAsync(request.Image, "Images");
            employee.Image = imageName;
        }

        unitOfWork.Employees.Add(employee);
        var result = await unitOfWork.SaveChangesAsync();
        if (result == 0)
            await documentService.DeleteAsync("", "");
        return result;
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var Employee = await unitOfWork.Employees.GetByIdAsync(id);
        if (Employee is null)
            return false;
        unitOfWork.Employees.Delete(Employee);

        return (await unitOfWork.SaveChangesAsync()) > 0;
    }
    public async Task<IEnumerable<EmployeeResponse>> GetAllAsync()
    {

        return await unitOfWork.Employees.GetAllAsQueryable()
            .ProjectTo<EmployeeResponse>(mapper.ConfigurationProvider).ToListAsync();
    }
    public async Task<IEnumerable<EmployeeResponse>> GetAllAsync(string name)
    {
        return await unitOfWork.Employees.GetAllAsQueryable()
            .Where(e => e.Name.Contains(name))
          .ProjectTo<EmployeeResponse>(mapper.ConfigurationProvider).ToListAsync();
    }
    public async Task<EmployeeDetailsResponse?> GetByIdAsync(int id)
    {
        var Employee = await unitOfWork.Employees.GetByIdAsync(id);
        return mapper.Map<EmployeeDetailsResponse?>(Employee);
    }
    public async Task<int> UpdateAsync(EmployeeUpdateRequest Employee)
    {
        unitOfWork.Employees.Update(mapper.Map<Employee>(Employee));
        return await unitOfWork.SaveChangesAsync();
    }
}
