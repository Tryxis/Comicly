using System.ComponentModel.DataAnnotations;

namespace ComiclyWebApp.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public int? CollectionTotal { get; set; }
        public Address? Address { get; set;}

        public ICollection<Club> Clubs { get; set; }
        public ICollection<Comic> Comics { get; set; }

    }
}
