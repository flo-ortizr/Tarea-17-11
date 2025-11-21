using Tarea_17_11.Models;

namespace Tarea_17_11.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> getAll();
        Task<Book> getOne(Guid id);
        Task Add(Book book);
        Task Update(Book book);
        Task Delete(Book book);
    }
}
