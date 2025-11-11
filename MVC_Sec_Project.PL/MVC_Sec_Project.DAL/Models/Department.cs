namespace MVC_Sec_Project.DAL.Models;
public class Department : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Description { get; set; } = null!;

    public ICollection<Employee> Employees { get; set; } = [];
}
