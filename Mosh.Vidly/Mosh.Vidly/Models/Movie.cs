using System.ComponentModel.DataAnnotations;

namespace Mosh.Vidly.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public int NumberInStock { get; set; }
    }
}