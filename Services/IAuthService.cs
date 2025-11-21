using Tarea_17_11.Models.DTOs;
using static Tarea_17_11.Models.DTOs.LoginResponse;

namespace Tarea_17_11.Services
{
    public interface IAuthService
    {
        Task<(bool ok, LoginResponseDto? response)> LoginAsync(LoginDto dto);
        Task<string> RegisterAsync(RegisterDto dto);
        Task<(bool ok, LoginResponseDto? response)> RefreshAsync(RefreshRequestDto dto);
    }
}
