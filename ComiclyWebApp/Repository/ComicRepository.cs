using ComiclyWebApp.Data;
using ComiclyWebApp.Interfaces;
using ComiclyWebApp.Models;
using Microsoft.EntityFrameworkCore;
namespace ComiclyWebApp.Repository
{
    public class ComicRepository : IComicRepository 
    {
        public readonly ComiclyDbConext _context;
        public ComicRepository(ComiclyDbConext context)
        {
            _context = context;
        }

        public bool Add(Comic comic)
        {
            _context.Add(comic);
            return Save();
        }

        public bool Delete(Comic comic)
        {
            _context.Remove(comic);
            return Save();
        }

        public async Task<IEnumerable<Comic>> GetAll()
        {
            return await _context.Comics.ToListAsync();
        }

        public async Task<Comic> GetComicByIdAsync(int id)
        {
            return await _context.Comics.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Comic>> GetComicsByCity(string city)
        {
            return await _context.Comics.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Comic comic)
        {
            throw new NotImplementedException();
        }
    }
}