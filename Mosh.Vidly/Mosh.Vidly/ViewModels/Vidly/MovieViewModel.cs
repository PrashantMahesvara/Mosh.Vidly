using Mosh.Vidly.Models;
using System.Collections.Generic;

namespace Mosh.Vidly.ViewModels.Vidly
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public Movie Movie { get; set; }
    }
}