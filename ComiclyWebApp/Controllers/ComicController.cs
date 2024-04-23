using ComiclyWebApp.Data;
using ComiclyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Detail(int id)
        {
            Comic comic = _context.Comics.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            {
                return View(comic);
            }
        }

    }
    
}