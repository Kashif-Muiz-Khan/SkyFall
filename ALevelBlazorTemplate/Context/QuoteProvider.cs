using Microsoft.EntityFrameworkCore;
using SkyFall.Model;

namespace SkyFall.Context
{
    public class QuoteProvider
    {
        private readonly DatabaseContext _context;

        public QuoteProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Quote>> GetAllQuotesAsync()
        {
            return await _context.Quotes.OrderBy(quote => quote.Author).ToListAsync();
        }

        public async Task AddQuoteAsync(Quote quote)
        {
            _context.Quotes.Add(quote);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCheeseAsync(Quote quote)
        {
            _context.Quotes.Update(quote);
            await _context.SaveChangesAsync();
        }

    }
}
