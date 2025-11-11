global using Microsoft.AspNetCore.Identity;
namespace MVC_Sec_Project.DAL.Models;
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}
