using AutoMapper;
using MVC_Sec_Project.Bll.DataTransferObjects.Employees;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MVC_Sec_Project.PL.Controllers;
[Authorize]
public class EmployeesController(IEmployeeService service,
   ILogger<EmployeesController> logger,
   IWebHostEnvironment env,
   IMapper mapper,
   IDepartmentService departmentService) : Controller
{


    // Transfer Data
    // Action => View 
    // View => Layout 
    // View => Partial 
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> Index(string? SearchValue)
    {
        if (string.IsNullOrWhiteSpace(SearchValue))
            return View(await service.GetAllAsync());
        else
            return View(await service.GetAllAsync(SearchValue));
    }


    #region Create 
    [HttpGet]
    public async Task<IActionResult> Create()
    {


        var departments = await departmentService.GetAllAsync();
        ViewBag.Departments = new
            SelectList(departments, "Id", "Name", null);
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(EmployeeRequest request)
    {

        // Server side Validation 
        if (!ModelState.IsValid)
            return View(request);

        try
        {
            // DB Insert 
            var result = await service.AddAsync(request);
            // Check 
            // Redirect 
            if (result > 0)

                TempData["Message"] = $"Employee  {request.Name} Created ";
            else
                TempData["Message"] = $"Can't Create Employee  {request.Name} ";
            return RedirectToAction(nameof(Index));

        }
        catch (Exception ex)
        {
            if (env.IsDevelopment())
                ModelState.AddModelError(string.Empty, ex.Message);
            // Add Model Error 
            // Log error 
            else
                logger.LogError(ex.Message);
        }

        return View(request);
    }
    #endregion


    #region Details
    [HttpGet]
    public IActionResult Details(int? id)
    {
        EmployeeDetailsResponse? Employee;
        (bool flowControl, IActionResult value) = ValidateEmployeeIdAndFetch(id, out Employee);
        if (!flowControl)
            return value;

        return View(Employee);
    }
    #endregion

    #region Edit
    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {

        EmployeeDetailsResponse? Employee;
        (bool flowControl, IActionResult value) = ValidateEmployeeIdAndFetch(id, out Employee);
        if (!flowControl)
            return value;
        var departments = await departmentService.GetAllAsync();
        ViewBag.Departments = new SelectList(departments, "Id", "Name");
        return View(mapper.Map<EmployeeUpdateRequest>(Employee));
    }



    [HttpPost]
    public async Task<IActionResult> Edit([FromRoute] int? id, EmployeeUpdateRequest request)
    {
        if (!id.HasValue)
            return BadRequest();
        if (id.Value != request.Id)
            return BadRequest();
        if (!ModelState.IsValid)
            return View(request);

        try
        {
            // DB Insert 
            var result = await service.UpdateAsync(request);
            // Check 
            // Redirect 
            if (result > 0)
                return RedirectToAction(nameof(Index));
            // Add Model Error 

            ModelState.AddModelError(string.Empty, "Can't Update Employee Now");
        }
        catch (Exception ex)
        {
            if (env.IsDevelopment())
                ModelState.AddModelError(string.Empty, ex.Message);
            // Add Model Error 
            // Log error 
            else
                logger.LogError(ex.Message);
        }

        return View(request);
    }

    #endregion

    [HttpGet]
    public IActionResult Delete(int? id)
    {

        EmployeeDetailsResponse? Employee;
        (bool flowControl, IActionResult value) = ValidateEmployeeIdAndFetch(id, out Employee);
        if (!flowControl)
            return value;

        return View(Employee);
    }


    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> ConfirmDelete(int? id)
    {
        if (!id.HasValue)
            return BadRequest(); // 400
        try
        {
            var result = await service.DeleteAsync(id.Value);
            if (result)
                return RedirectToAction(nameof(Index));

            ModelState.AddModelError(string.Empty, "Can't Create Employee");
            return View(result);
        }
        catch (Exception ex)
        {
            if (env.IsDevelopment())
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            logger.LogError(ex.Message);
            ModelState.AddModelError(string.Empty, "Can't Create Employee");

        }
        return View();
    }



    // Helpers 

    private (bool flowControl, IActionResult value) ValidateEmployeeIdAndFetch(int? id, out EmployeeDetailsResponse? Employee)
    {
        if (!id.HasValue)
        {
            Employee = default;
            return (flowControl: false, value: BadRequest());
        }

        Employee = service.GetByIdAsync(id.Value).GetAwaiter().GetResult();
        if (Employee == null)
            return (flowControl: false, value: NotFound());
        return (flowControl: true, value: null);
    }
}

