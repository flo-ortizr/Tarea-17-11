namespace Tarea_17_11.Models.DTOs
{
    public class LoginResponse
    {
        public class LoginResponseDto
        {
            public required UserDto User { get; set; }
            public required string Role { get; set; }
            public required string AccessToken { get; set; }
            public required string RefreshToken { get; set; }
            public string TokenType { get; set; } = "Bearer";
            public int ExpiresIn { get; set; } //sec
        }
    }
}
