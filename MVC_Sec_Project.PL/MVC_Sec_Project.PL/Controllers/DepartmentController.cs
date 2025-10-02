using Microsoft.AspNetCore.Mvc;
using MVC_Sec_Project.Bll.Services;

namespace MVC_Sec_Project.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices DepartmentServices;
        public DepartmentController(IDepartmentServices department)
        {
          this.DepartmentServices = department;    
        }
        public IActionResult Index()
        {
            var Depts = DepartmentServices.GetAllDepartments();
            return View(Depts);
        }
    }
}
