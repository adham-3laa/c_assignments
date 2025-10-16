using System.ComponentModel.DataAnnotations;

namespace MVC_Sec_Project.PL.ViewModels.DepartmentVms
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Requred")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Code Is Requred")]

        public string Code { get; set; }
    }
}
