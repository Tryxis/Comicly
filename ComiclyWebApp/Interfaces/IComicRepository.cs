using ComiclyWebApp.Models;
namespace ComiclyWebApp.Interfaces
{
    public interface IComicRepository
    {
        Task<IEnumerable<Comic>> GetAll();
        Task<Comic> GetComicByIdAsync(int id);
        Task<IEnumerable<Comic>> GetComicsByCity(string city);
        bool Add(Comic comic);
        bool Update (Comic comic);
        bool Delete(Comic comic);
        bool Save();
    }
}