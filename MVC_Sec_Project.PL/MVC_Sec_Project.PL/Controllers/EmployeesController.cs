using Humanizer;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using MVC_Sec_Project.Bll.Dto_s.DepartmentDto_s;
using MVC_Sec_Project.Bll.Dto_s.EmployeeDto_s;
using MVC_Sec_Project.Bll.Services.Classes;
using MVC_Sec_Project.Bll.Services.Intrfaces;
using MVC_Sec_Project.DAL.Models.Shared.Enums;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using MVC_Sec_Project.PL.ViewModels.DepartmentVms;

namespace MVC_Sec_Project.PL.Controllers
{
    public class EmployeesController(IEmployeeServices _employeeServices, IWebHostEnvironment webHost, ILogger<DepartmentController> logger) : Controller
    {
        public IActionResult Index()
        {
            var employees = _employeeServices.GetAllEmployee();
            return View(employees ?? new List<EmployeeDto>());
        }
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(CreatedEmployeeDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int Result = _employeeServices.AddEmployee(dto);
                    if (Result > 0) return RedirectToAction("Index");
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Employee can't Be Created");
                        return View(dto);
                    }
                }
                catch (Exception ex)
                {
                    if (webHost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(dto);
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
                return View(dto);
            }
        }
        [HttpGet]
        public IActionResult Details([FromRoute] int? Id)
        {
            if (Id == null) return BadRequest();
            var emp = _employeeServices.GetEmployeeById(Id.Value);
            if (emp == null) return NotFound();
            return View(emp);
        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null) return BadRequest();
            var emp = _employeeServices.GetEmployeeById(Id.Value);
            if (emp == null) return NotFound();
            var dto = new UpdatedEmployeeDto()
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                Address = emp.Address,
                Email = emp.Email,
                PhoneNumber = emp.PhoneNumber,
                Salary = emp.Salary,
                HiringDate = emp.HiringDate,
                IsActive = emp.IsActive,
                EmployeeType = Enum.Parse<EmployeeType>(emp.EmployeeType),
                Gender = Enum.Parse<Gender>(emp.Gender)

            };
            return View(dto);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, UpdatedEmployeeDto dto)
        {
            if (id != dto.Id) return BadRequest();
            if (!ModelState.IsValid) return View(dto);
            
            try
            {
                int Result = _employeeServices.UpdateEmployee(dto);
                if (Result > 0) return RedirectToAction("Index");
                else
                {
                    ModelState.AddModelError(string.Empty, "Department can't Be Created");
                    return View(dto);
                }
            }
            catch (Exception ex)
            {
                if (webHost.IsDevelopment())
                {
                    logger.LogError(ex.Message);
                    return View(dto);
                }
                else
                {
                    //store at table in database
                    throw;

                }
            }



        }
        [HttpPost]
        public IActionResult Delete([FromRoute] int? id)
        {
            var Message = string.Empty;
            try
            {
                var IsDeleted = _employeeServices.DeleteEmployee(id.Value);
                if (IsDeleted is true)
                    return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                Message = ex.Message;

            }
            ModelState.AddModelError(string.Empty, Message);
            return RedirectToAction(nameof(Delete), new { id = id });

        }



    }
    }
