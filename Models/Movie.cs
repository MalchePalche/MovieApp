using System.ComponentModel.DataAnnotations;

namespace IMDB_Clone_Web_App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cast { get; set; }
        public string Summary { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
