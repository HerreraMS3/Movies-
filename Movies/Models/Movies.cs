using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        DateTime ReleaseDate { get; set; }
        public string? genre { get; set; }
        public decimal price { get; set; }
    }
}