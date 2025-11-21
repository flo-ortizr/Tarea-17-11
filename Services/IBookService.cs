using Tarea_17_11.Models;
using Tarea_17_11.Models.DTOs;

namespace Tarea_17_11.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book?> GetOne(Guid id);
        Task<Book> CreateBook(CreateBookDto dto);
        Task<Book> UpdateBook(UpdateBookDto dto, Guid id);
        Task DeleteBook(Guid id);
    }
}
