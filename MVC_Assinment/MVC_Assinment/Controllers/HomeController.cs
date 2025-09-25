using Microsoft.AspNetCore.Mvc;
using MVC_Assinment.Models;

namespace MVC_Assinment.Controllers
{
    public class HomeController : Controller
    {
        //Main Action : index => GetAllData || GetById =>Opject || Create => AddNewOpject || Updata => UpdateOpject || Delete => RemoveOpject
        //Main of Controller
        public IActionResult Index()
        {
            Movie movie = new Movie() { Id = 1, Title = "Avengers" };
            return View();//Rasor view => C# + HTML 
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
