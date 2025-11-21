using Microsoft.EntityFrameworkCore;
using Tarea_17_11.Data;
using Tarea_17_11.Models;

namespace Tarea_17_11.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _db;
        public BookRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task Add(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Book book)
        {
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> getAll()
        {
            return await _db.Books.ToListAsync();
        }

        public async Task<Book?> getOne(Guid id)
        {
            return await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Book book)
        {
            _db.Books.Update(book);
            await _db.SaveChangesAsync();
        }
    }
}
