using Microsoft.EntityFrameworkCore;
using SkyFall.Model;

namespace SkyFall.Context
{
    public class AuthorProvider
    {
        private readonly DatabaseContext _context;

        public AuthorProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            return await _context.Authors.OrderBy(author => author.Name).ToListAsync();
        }

        public async Task AddAuthorAsync(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            _context.Authors.Update(author);
            await _context.SaveChangesAsync();
        }

    }
}
