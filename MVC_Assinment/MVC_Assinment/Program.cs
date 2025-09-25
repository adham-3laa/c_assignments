using MVC_Assinment.Controllers;


namespace MVC_Assinment
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            //MoviesController moviescontroller = new MoviesController(); 
            

            //moviescontroller.Index();

            var builder = WebApplication.CreateBuilder(args);
            #region Configure app services
            builder.Services.AddControllersWithViews();
            #endregion

            var app = builder.Build();
            app.UseRouting();//middleware -> routing table
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default:",
                                //pattern: "{controller=Movies}/{action=Index}/{id?}/{Name?}"
                                //pattern: "{controller=Movies}/{action=Index}"
                                pattern: "{controller=Home}/{action=Index}"

                ); 
            #region minimal api
            // app.MapGet("/", () => "Hello World!");
            // //static segement
            // app.MapGet("/adham", () => "Hello Adham!");
            // //Dinamic segement
            // //app.MapGet("/{name}", async Context =>
            // //{
            // //    var Name = Context.GetRouteValue("name");
            // //    await Context.Response.WriteAsync($"Hello {Name}");
            // //}
            // //);
            // //mix
            // app.MapGet("/A {name}", async Context =>
            // {
            //     var Name = Context.GetRouteValue("name");
            //     await Context.Response.WriteAsync($"Hello {Name}");
            // }
            //);
            // //post
            // app.MapPost("/post", () => "Hello Post!"); 

            #endregion

            app.Run();
        }
    }
}
