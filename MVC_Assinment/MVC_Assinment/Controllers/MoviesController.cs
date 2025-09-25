using Microsoft.AspNetCore.Mvc;
using MVC_Assinment.Models;

namespace MVC_Assinment.Controllers
{
    public class MoviesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello from Controller";
            //result.ContentType = "text/html";
            //result.StatusCode = 200;
            return Content("Hello from Controller", "text/html");
        }
        public RedirectToActionResult GoGoogle()
        {
           // RedirectResult result = new RedirectResult("https://www.google.com");
             //redirectToActionResult = new RedirectToActionResult("index","Movies",null);
            //return result
         return RedirectToAction("Index","Movies");

        }
        public IActionResult GetMovie(int id)
        {
            if (id == 0)
                return BadRequest();
            else if (id < 10)
                return NotFound();
            else
                return Content($"Movie Id : {id}");
        }
        //public ActionResult GetMovie(int id)
        //{
        //    return Content($"Movie Id : {id}"); 
        //}//[fromroute] [fromquery] [frombody] [fromForm] use this to specify the source of data
        //the default order is form->route->query->body
        public IActionResult GetMovieByName([FromQuery]int Id,[FromQuery] string name)
        {
            return Content($"Movie Id : {Id} and Movie Name : {name}");
        }
        public IActionResult AddMovie(Movie movie)
        {
            return Content($"Movie Id : {movie.Id}, Movie title : {movie.Title}");
        }
        public IActionResult AddArray(int[] arr)
        {
            return Content($"{arr[0]}");
        }

    }
}
