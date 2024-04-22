using ComiclyWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ComiclyWebApp.Data
{
    public class ComiclyDbConext : DbContext
    {
        public ComiclyDbConext(DbContextOptions<ComiclyDbConext> options) : base(options)
        {

        }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses{ get; set; }
    }   

}