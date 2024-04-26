using ComiclyWebApp.Data;
using ComiclyWebApp.Interfaces;
using ComiclyWebApp.Models;
using ComiclyWebApp.Services;
using ComiclyWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComiclyWebApp
{
    public class ComicController : Controller
    {
        private readonly IComicRepository _comicRepository;
        private readonly IPhotoService _photoService;

        public ComicController(IComicRepository comicRepository, IPhotoService photoService)
        {
            _comicRepository = comicRepository;
            _photoService = photoService;
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
        public async Task <IActionResult> Create(CreateComicVm comicVM)
        {
            if(ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(comicVM.Image);
                var comic = new Comic
                {
                    Title = comicVM.Title,
                    Description = comicVM.Description,
                    Image = result.Url.ToString(),
                    Address = new Address
                    {
                        Street = comicVM.Address.Street,
                        City = comicVM.Address.City,
                        Postcode = comicVM.Address.Postcode
                    }
                };
                _comicRepository.Add(comic);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }
            return View(comicVM);
        }

    }
    
}