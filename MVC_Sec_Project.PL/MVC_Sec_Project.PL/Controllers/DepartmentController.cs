using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s;
using MVC_Sec_Project.Bll.Services.Intrfaces;
using MVC_Sec_Project.PL.ViewModels.DepartmentVms;

namespace MVC_Sec_Project.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices DepartmentServices;
        private readonly ILogger<DepartmentController> logger;
        private readonly IWebHostEnvironment webHost;

        public DepartmentController(IDepartmentServices department, ILogger<DepartmentController> logger, IWebHostEnvironment webHost)
        {
            this.DepartmentServices = department;
            this.logger = logger;
            this.webHost = webHost;
        }
        public IActionResult Index()
        {
            //ViewData["Msg"] = "Hello From View Data";
            //ViewBag.Msg = "Hello From View Bag";

            ViewData["Department"] = new DepartmentDto() { Name = "Departments List" };
            ViewBag.Department02 = new DepartmentDto() { Name = "TestViewBag" };
            var Depts = DepartmentServices.GetAllDepartments();
            return View(Depts);
        }
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DepartmentViewModel departmentModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var departmentDto = new CreatedDepartmentDto()
                    {
                        Code = departmentModel.Code,
                        Name = departmentModel.Name,
                        Description = departmentModel.Description
                    };
                    int Result = DepartmentServices.AddDepartment(departmentDto);
                    //if (Result > 0) return RedirectToAction("Index");
                    //else
                    //{
                    //    ModelState.AddModelError(string.Empty, "Department can't Be Created");
                    //    return View(departmentViewModel);
                    //}

                    string msg;
                    if (Result > 0) msg = $"Department {departmentModel.Name}  is  Department created successfully";
                    else msg = $"Department {departmentModel.Name}  is not created , please try again";

                    TempData["Message"] = msg;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (webHost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(departmentModel);
                    }
                    else
                    {
                        //store at table in database
                        throw;

                    }
                }
            }
            else
            {
                return View(departmentModel);
            }
        }
        [HttpGet]
        public IActionResult Details([FromRoute] int? Id)
        {
            if (Id == null) return BadRequest();
            var Department = DepartmentServices.GetDepartmentById(Id.Value);
            if (Department == null) return NotFound();
            return View(Department);
        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null) return BadRequest();
            var Department = DepartmentServices.GetDepartmentById(Id.Value);
            if (Department == null) return NotFound();
            var ViewDepartment = new DepartmentViewModel()
            {
                Id = Department.ID,
                Name = Department.Name,
                Description = Department.Description,
                Code = Department.Code
            };
            return View(ViewDepartment);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int? id,DepartmentViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var Department = new UpdateDepartmentDto()
            {
                Id= model.Id,
                Name = model.Name,
                Description = model.Description,
                Code = model.Code
            };
            try
            {
                int Result = DepartmentServices.UpdateDepartment(Department);
                if (Result > 0) return RedirectToAction("Index");
                else
                {
                    ModelState.AddModelError(string.Empty, "Department can't Be Created");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                if (webHost.IsDevelopment())
                {
                    logger.LogError(ex.Message);
                    return View(model);
                }
                else
                {
                    //store at table in database
                    throw;

                }
            }
           


        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null) return BadRequest();
            var Department = DepartmentServices.GetDepartmentById(Id.Value);
            if (Department == null) return NotFound();
            return View(Department);

        }
        [HttpPost]
        public IActionResult Delete(int DeptId)
        {
            var Message = string.Empty;
            try
            {
              var IsDeleted = DepartmentServices.DeleteDepartment(DeptId);
                if(IsDeleted==1)
                    return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                logger.LogError(ex,ex.Message);
                Message = ex.Message;
                
            }
            ModelState.AddModelError(string.Empty,Message);
            return RedirectToAction(nameof(Delete), new {id=DeptId});

        }
    }
}