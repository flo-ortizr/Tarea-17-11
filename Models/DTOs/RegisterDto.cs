namespace Tarea_17_11.Models.DTOs
{
    public record RegisterDto
    {
        public string Username { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public string Role { get; set; } = "User";
    }
}
