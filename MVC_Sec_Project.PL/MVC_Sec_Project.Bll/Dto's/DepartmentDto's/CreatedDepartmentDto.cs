using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s
{
    public class CreatedDepartmentDto
    {
        [Required(ErrorMessage = "Code is Requred")]

        public string Code { get; set; }
        [Required(ErrorMessage ="Name is Requred")]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
