using Tarea_17_11.Models;
using Tarea_17_11.Models.DTOs;
using Tarea_17_11.Repositories;

namespace Tarea_17_11.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }
        public async Task<Book> CreateBook(CreateBookDto dto)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = dto.Title,
                Year = dto.Year,
                Author = dto.Author,
                Genre = dto.Genre
            };
            await _repo.Add(book);
            return book;
        }

        public Task DeleteBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _repo.getAll();
        }

        public async Task<Book?> GetOne(Guid id)
        {
            return await _repo.getOne(id);
        }

        public async Task<Book> UpdateBook(UpdateBookDto dto, Guid id)
        {
            Book? book = await GetOne(id);
            if (book == null) throw new Exception("Book does not exist.");

            book.Title = dto.Title;
            book.Year = dto.Year;
            book.Author = dto.Author;
            book.Genre = dto.Genre;

            await _repo.Update(book);
            return book;
        }
    }
}
