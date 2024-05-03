using Microsoft.EntityFrameworkCore;
using SkyFall.Model;

namespace SkyFall.Context
{
    public class BookProvider
    {
        private readonly DatabaseContext _context;

        public BookProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.OrderBy(book => book.Title).ToListAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

    }
}
