using ComiclyWebApp.Data.Enum;
using ComiclyWebApp.Models;

namespace ComiclyWebApp.ViewModels
{
    public class CreateComicVm
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public ClubCategory ClubCategory { get; set; }

    }
}