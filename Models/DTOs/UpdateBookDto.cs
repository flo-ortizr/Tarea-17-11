namespace Tarea_17_11.Models.DTOs
{
    public record UpdateBookDto
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
