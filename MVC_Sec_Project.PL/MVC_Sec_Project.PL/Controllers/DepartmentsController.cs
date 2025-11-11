global using MVC_Sec_Project.Bll.DataTransferObjects.Departments;
global using MVC_Sec_Project.Bll.Services;
global using Microsoft.AspNetCore.Mvc;

namespace MVC_Sec_Project.PL.Controllers;
public class DepartmentsController(IDepartmentService service,
   ILogger<DepartmentsController> logger,
   IWebHostEnvironment env) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {

        // Get All Departments 
        // Pass to View 
        var departments = await service.GetAllAsync();

        return View(departments);
    }


    #region Create 
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [ValidateAntiForgeryToken]
    [HttpPost]
    public async Task<IActionResult> Create(DepartmentRequest request)
    {

        // Server side Validation 
        if (!ModelState.IsValid)
            return View(request);

        try
        {
            // DB Insert 
            var result = await service.CreateAsync(request);
            // Check 
            // Redirect 
            if (result > 0)
                return RedirectToAction(nameof(Index));
            // Add Model Error 

            ModelState.AddModelError(string.Empty, "Can't Add Department Now");
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
    public async Task<IActionResult> Details(int? id)
    {
        if (!id.HasValue)
            return BadRequest();

        var department = await service.GetByIdAsync(id.Value);
        if (department == null)
            return NotFound();

        return View(department);
    }
    #endregion

    #region Edit
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        DepartmentDetailsResponse? department;
        (bool flowControl, IActionResult value) = ValidateDepartmentIdAndFetch(id, out department);
        if (!flowControl)
        {
            return value;
        }

        return View(department.ToUpdateRequest());
    }

    private (bool flowControl, IActionResult value) ValidateDepartmentIdAndFetch(int? id, out DepartmentDetailsResponse? department)
    {
        if (!id.HasValue)
        {
            department = default;
            return (flowControl: false, value: BadRequest());
        }

        department = service.GetByIdAsync(id.Value).GetAwaiter().GetResult();
        if (department == null)
            return (flowControl: false, value: NotFound());
        return (flowControl: true, value: null);
    }

    [HttpPost]
    public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] DepartmentUpdateRequest request)
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

            ModelState.AddModelError(string.Empty, "Can't Update Department Now");
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
    public async Task<IActionResult> Delete(int? id)
    {

        if (!id.HasValue)
            return BadRequest();

        var department = await service.GetByIdAsync(id.Value);
        if (department == null)
            return NotFound();

        return View(department.ToUpdateRequest());
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

            ModelState.AddModelError(string.Empty, "Can't Create Department");
            return View(result);
        }
        catch (Exception ex)
        {
            if (env.IsDevelopment())
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            logger.LogError(ex.Message);
            ModelState.AddModelError(string.Empty, "Can't Create Department");

        }
        return View();
    }



    // Helpers 


}
