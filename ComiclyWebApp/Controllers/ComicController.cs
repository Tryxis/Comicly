using ComiclyWebApp.Data;
using ComiclyWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComiclyWebApp
{
    public class ComicController : Controller
    {
        private readonly ComiclyDbConext _context;

        public ComicController(ComiclyDbConext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Comic> comics = _context.Comics.ToList();
            return View(comics);
        } 

    }
    
}