global using MVC_Sec_Project.DAL.Models;
global using Microsoft.AspNetCore.Identity;
using MVC_Sec_Project.PL.ViewModels;

namespace MVC_Sec_Project.PL.Controllers;
public class AccountController(UserManager<ApplicationUser> userManager,
   SignInManager<ApplicationUser> signInManager)
    : Controller
{

    // Register
    // Login 
    // Logout 
    // Reset Password 
    // Forget Password 
    [HttpGet]
    public IActionResult Register()
    {

        // View 
        // ViewModel 
        // AuthLayout
        // 
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        try
        {
            // Model => Application User 
            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };

            // UserManage.Create(User)
            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
                return RedirectToAction("Login");

            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);
            return View(model);

        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        var user = await userManager.FindByEmailAsync(model.Email);
        if (user != null)
        {
            if (await userManager.CheckPasswordAsync(user, model.Password))
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
            }
        }
        ModelState.AddModelError(string.Empty, "Invalid Email or Password");
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }

}

// Authentication 
// Who R U 
// password + key =>  Encrypted password
// Encrypted password   + key => password  
// password + hashing => hashedPassword  => store in DB 
// Login  => Password + Hashing 
// HTTP is Stateless 
// Login => (user + Password)  => Server Generates Token 
// Token => Encrypted String => UserName , Email , Role , Exp
// Authorization 
// Role based Auth 
// Permission Based 
// Policy based 


// User 
// Role 
// UserRoles
// UserClaims
// RoleClaims
// UserLogins
// UserTokens