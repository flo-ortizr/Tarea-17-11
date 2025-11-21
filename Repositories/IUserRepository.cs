using Tarea_17_11.Models;

namespace Tarea_17_11.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetById(Guid id);
        Task<User?> GetByEmailAddress(string email);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
    }
}
