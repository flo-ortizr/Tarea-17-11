using System.ComponentModel.DataAnnotations;

namespace Tarea_17_11.Models.DTOs
{
    public record CreateBookDto
    {
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
