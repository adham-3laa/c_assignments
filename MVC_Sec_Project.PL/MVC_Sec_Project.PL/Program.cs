
using Microsoft.EntityFrameworkCore;
using MVC_Sec_Project.Bll.Mapping_Profiles;
using MVC_Sec_Project.Bll.Services.Classes;
using MVC_Sec_Project.Bll.Services.Intrfaces;
using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Reposatories.Classes;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using NuGet.Protocol.Core.Types;

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
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfiles()));
            builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();


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
