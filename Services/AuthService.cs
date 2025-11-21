using Tarea_17_11.Models.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Tarea_17_11.Services
{
    public class AuthService : IAuthService
    {
        public Task<(bool ok, LoginResponse.LoginResponseDto? response)> LoginAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<(bool ok, LoginResponse.LoginResponseDto? response)> RefreshAsync(LoginResponse.RefreshRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<string> RegisterAsync(RegisterDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
