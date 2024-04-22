using ComiclyWebApp.Data;
using ComiclyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiclyWebApp
{
    public class ClubController : Controller
    {
        private readonly ComiclyDbConext _context;
        public ClubController(ComiclyDbConext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        } 
        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            {
                return View(club);
            }
        }
    }
    
}