using ComiclyWebApp.Data;
using ComiclyWebApp.Interfaces;
using ComiclyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiclyWebApp
{
    public class ComicController : Controller
    {
        private readonly IComicRepository _comicRepository;

        public ComicController(IComicRepository comicRepository)
        {
            _comicRepository = comicRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Comic> comics =  await _comicRepository.GetAll();
            return View(comics);
        } 

        public async Task<IActionResult> Detail(int id)
        {
            Comic comic = await _comicRepository.GetComicByIdAsync(id);
            {
                return View(comic);
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task <IActionResult> Create(Comic comic)
        {
            if(!ModelState.IsValid)
            {
                return View(comic);
            }
            _comicRepository.Add(comic);
            return RedirectToAction("Index");
        }

    }
    
}