using System.ComponentModel.DataAnnotations;

namespace MVC_Sec_Project.Bll.DataTransferObjects.Departments;
public class DepartmentRequest
{
    [Required(ErrorMessage = "Name Is Required !!")]
    public string Name { get; set; } = null!;
    [MaxLength(5)]
    public string Code { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }
}
