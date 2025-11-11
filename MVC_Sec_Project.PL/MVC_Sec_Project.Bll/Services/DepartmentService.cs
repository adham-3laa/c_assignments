using MVC_Sec_Project.Bll.DataTransferObjects.Departments;

namespace MVC_Sec_Project.Bll.Services;
public class DepartmentService(IUnitOfWork unitOfWork)
    : IDepartmentService
{
    public async Task<int> CreateAsync(DepartmentRequest request)
    {

        // Mapping Manual 
        // AutoMapper 
        // Mapster
        // Extension Methods 
        //var department = new Department
        //{
        //    Code = request.Code,
        //    Description = request.Description,
        //    Name = request.Name,
        //};
        unitOfWork.Departments.Add(request.ToEntity());
        return await unitOfWork.SaveChangesAsync();
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var department = await unitOfWork.Departments.GetByIdAsync(id);
        if (department is null)
            return false;
        unitOfWork.Departments.Delete(department);
        var result = await unitOfWork.SaveChangesAsync();
        return result > 0;
    }

    public async Task<IEnumerable<DepartmentResponse>> GetAllAsync()
        => (await unitOfWork.Departments.GetAllAsync()).Select(x => x.ToResponse());

    public async Task<DepartmentDetailsResponse?> GetByIdAsync(int id)
    {
        var department = await unitOfWork.Departments.GetByIdAsync(id);
        return department?.ToDetailsResponse();
    }

    public async Task<int> UpdateAsync(DepartmentUpdateRequest department)
    {
        unitOfWork.Departments.Update(department.ToEntity());
        return await unitOfWork.SaveChangesAsync();
    }
}
