using MVC_Sec_Project.DAL.Context;
using MVC_Sec_Project.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MVC_Sec_Project.PL;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IDepartmentService, DepartmentService>();
        builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddScoped<IDocumentService, DocumentService>();

        builder.Services.AddDbContext<CompanyDbContext>(options =>
        {
            
            var connection = builder.Configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connection);
        });
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();

        builder.Services.AddAutoMapper(typeof(Bll.AssemblyReference).Assembly);

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(o =>
        {
        })
        .AddEntityFrameworkStores<CompanyDbContext>();




        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();



        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
