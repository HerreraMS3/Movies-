using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int id { get; set; }
        [Display(Name ="Titulo")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Liberacion")]
        DateTime ReleaseDate { get; set; }
        [Display(Name = "Genero")]
        public string? genre { get; set; }
        [Display(Name = "Precio")]
        public decimal price { get; set; }
    }
}