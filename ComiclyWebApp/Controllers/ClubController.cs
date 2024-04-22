using Microsoft.AspNetCore.Mvc;

namespace ComiclyWebApp
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
    
}