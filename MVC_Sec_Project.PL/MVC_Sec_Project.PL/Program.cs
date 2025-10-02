
using Microsoft.EntityFrameworkCore;
using MVC_Sec_Project.Bll.Services;
using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Reposatories.DepartmentRepo;

namespace MVC_Sec_Project.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Register the DbContext with the dependency injection container
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IDepartmentReposatory, DepartmentReposatory>();
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
