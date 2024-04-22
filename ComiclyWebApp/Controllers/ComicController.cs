using Microsoft.AspNetCore.Mvc;

namespace ComiclyWebApp
{
    public class ComicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
    
}