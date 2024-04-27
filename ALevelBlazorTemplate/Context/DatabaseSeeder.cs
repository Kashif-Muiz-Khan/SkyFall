using Microsoft.AspNetCore.Identity;
using SkyFall.Model;
using Microsoft.EntityFrameworkCore;


namespace SkyFall.Context
{
    public class DatabaseSeeder
    {

        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DatabaseSeeder(DatabaseContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task Seed()
        {
            await _context.Database.MigrateAsync();




            if (!_context.Users.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
                await _roleManager.CreateAsync(new IdentityRole("Customer"));

                var adminEmail = "admin@skyfall.com";
                var adminPassword = "Skyfall007!";

                var admin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FirstName = "Admin",
                    LastName = "User",
                    Address = "007 Admin Street",
                    City = "Bondville",
                    PostCode = "BO07 OND"
                };

                await _userManager.CreateAsync(admin, adminPassword);
                await _userManager.AddToRoleAsync(admin, "Admin");
            }


            //    if (!_context.Authors.Any())
            //    {
            //        var authors = GetAuthors();
            //        _context.Quotes.AddRange(authors);
            //        await _context!.SaveChangesAsync();
            //    }

            //    if (!_context.Quotes.Any())
            //    {
            //        var quotes = GetQuotes();
            //        _context.Quotes.AddRange(quotes);
            //        await _context!.SaveChangesAsync();
            //    }         
            //}

            //private List<Book> GetBooks()
            //{
            //    var authors = GetAuthors();
            //    return [

            //    new Book { BookID = 1, Title = "Nicomachean Ethics", Description = "A philosophical work by Aristotle on ethics and moral philosophy.", Pages = 320, Genre = "Philosophy", Price = ConvertToGBP(12.99m), AuthorID = authors[0] },
            //    new Book { BookID = 2, Title = "The Art of War", Description = "An ancient Chinese military treatise attributed to Sun Tzu.", Pages = 88, Genre = "Military", Price = ConvertToGBP(8.49m), AuthorID = authors[1] },
            //    new Book { BookID = 3, Title = "The Republic", Description = "A Socratic dialogue written by Plato around 380 BC.", Pages = 336, Genre = "Philosophy", Price = ConvertToGBP(14.99m), AuthorID = authors[2] },
            //    new Book { BookID = 4, Title = "Meditations", Description = "A series of personal writings by Marcus Aurelius, Roman Emperor.", Pages = 304, Genre = "Philosophy", Price = ConvertToGBP(10.79m), AuthorID = authors[18] },
            //    new Book { BookID = 5, Title = "The Communist Manifesto", Description = "A political pamphlet by Karl Marx and Friedrich Engels.", Pages = 48, Genre = "Political Philosophy", Price = ConvertToGBP(6.29m), AuthorID = authors[7] },
            //    new Book { BookID = 6, Title = "The Wealth of Nations", Description = "A book by Adam Smith, considered the first modern work of economics.", Pages = 636, Genre = "Economics", Price = ConvertToGBP(17.49m), AuthorID = authors[4] },
            //    new Book { BookID = 7, Title = "Discourses on Livy", Description = "A work of political history and philosophy by Niccolò Machiavelli.", Pages = 388, Genre = "Political Philosophy", Price = ConvertToGBP(13.99m), AuthorID = authors[10] },
            //    new Book { BookID = 8, Title = "The Prince", Description = "A 16th-century political treatise by Niccolò Machiavelli.", Pages = 140, Genre = "Political Philosophy", Price = ConvertToGBP(9.99m), AuthorID = authors[10] },
            //    new Book { BookID = 9, Title = "Critique of Pure Reason", Description = "A philosophical work by Immanuel Kant.", Pages = 784, Genre = "Philosophy", Price = ConvertToGBP(19.99m), AuthorID = authors[5] },
            //    new Book { BookID = 10, Title = "Analects", Description = "A collection of sayings and ideas attributed to Confucius.", Pages = 256, Genre = "Philosophy", Price = ConvertToGBP(11.99m), AuthorID = authors[9] },
            //    new Book { BookID = 11, Title = "The Gospel According to Jesus Christ", Description = "A novel by the Portuguese author José Saramago.", Pages = 398, Genre = "Fiction", Price = ConvertToGBP(15.29m), AuthorID = authors[13] },
            //    new Book { BookID = 12, Title = "Common Sense", Description = "A pamphlet written by Thomas Paine advocating independence from Great Britain.", Pages = 96, Genre = "Political Philosophy", Price = ConvertToGBP(7.99m), AuthorID = authors[15] },
            //    new Book { BookID = 13, Title = "The Art of War", Description = "An ancient Chinese military treatise attributed to Sun Tzu.", Pages = 88, Genre = "Military", Price = ConvertToGBP(8.49m), AuthorID = authors[1] },
            //    new Book { BookID = 14, Title = "The Prince", Description = "A 16th-century political treatise by Niccolò Machiavelli.", Pages = 140, Genre = "Political Philosophy", Price = ConvertToGBP(9.99m), AuthorID = authors[10] },
            //    new Book { BookID = 15, Title = "The Wealth of Nations", Description = "A book by Adam Smith, considered the first modern work of economics.", Pages = 636, Genre = "Economics", Price = ConvertToGBP(17.49m), AuthorID = authors[4] },
            //    new Book { BookID = 16, Title = "The Art of War", Description = "An ancient Chinese military treatise attributed to Sun Tzu.", Pages = 88, Genre = "Military", Price = ConvertToGBP(8.49m), AuthorID = authors[1] },
            //    new Book { BookID = 17, Title = "The Prince", Description = "A 16th-century political treatise by Niccolò Machiavelli.", Pages = 140, Genre = "Political Philosophy", Price = ConvertToGBP(9.99m), AuthorID = authors[10] },
            //    new Book { BookID = 18, Title = "The Wealth of Nations", Description = "A book by Adam Smith, considered the first modern work of economics.", Pages = 636, Genre = "Economics", Price = ConvertToGBP(17.49m), AuthorID = authors[4] },
            //    new Book { BookID = 19, Title = "The Art of War", Description = "An ancient Chinese military treatise attributed to Sun Tzu.", Pages = 88, Genre = "Military", Price = ConvertToGBP(8.49m), AuthorID = authors[1] },
            //    new Book { BookID = 20, Title = "The Prince", Description = "A 16th-century political treatise by Niccolò Machiavelli.", Pages = 140, Genre = "Political Philosophy", Price = ConvertToGBP(9.99m), AuthorID = authors[10] }


            //    ];
            //}

            //private List<Quote> GetQuotes()
            //{
            //    return
            //    [
            //        new Quote { QuoteText = "Knowing yourself is the beginning of all wisdom."  },
            //        new Quote { QuoteText = "We are what we repeatedly do. Excellence, then, is not an act, but a habit."  },
            //        new Quote { QuoteText = "In peace, prepare for war. In war, prepare for peace."  },
            //        new Quote { QuoteText = "Opportunities multiply as they are seized."  },
            //        new Quote { QuoteText = "The measure of a man is what he does with power."  },
            //        new Quote { QuoteText = "Courage is the first of human qualities because it is the quality which guarantees the others." },
            //        new Quote { QuoteText = "Victorious warriors win first and then go to war, while defeated warriors go to war first and then seek to win." },
            //        new Quote { QuoteText = "History is a set of lies agreed upon." },
            //        new Quote { QuoteText = "All money is a matter of belief." },
            //        new Quote { QuoteText = "The greatest happiness of the greatest number is the foundation of morals and legislation." },
            //        new Quote { QuoteText = "Act only according to that maxim whereby you can at the same time will that it should become a universal law." },
            //        new Quote { QuoteText = "Happiness is not an ideal of reason, but of imagination." },
            //        new Quote { QuoteText = "Associate yourself with men of good quality if you esteem your own reputation." },
            //        new Quote { QuoteText = "It is better to offer no excuse than a bad one." },
            //        new Quote { QuoteText = "The history of all previous societies has been the history of class struggles." },
            //        new Quote { QuoteText = "Religion is the sigh of the oppressed creature, the heart of a heartless world, and the soul of soulless conditions. It is the opium of the people."},
            //        new Quote { QuoteText = "There is nothing impossible to him who will try." },
            //        new Quote { QuoteText = "There is one kind of robber whom the law does not strike at, and who steals what is most precious to men: time."},
            //        new Quote { QuoteText = "The only true wisdom is in knowing you know nothing." },
            //        new Quote { QuoteText = "I cannot teach anybody anything. I can only make them think."}
            //    ];
            //}

            //private List<Author> GetAuthors()
            //{
            //    return
            //    [
            //        new Author { Name = "Aristotle", BirthDate = new DateTime(384, 1, 1), DeathDate = new DateTime(322, 1, 1), Lifespan = "62yrs", Occupation = "Philosopher", Country = "Greece" },
            //        new Author { Name = "Sun Tzu", BirthDate = new DateTime(544, 1, 1), DeathDate = new DateTime(496, 1, 1), Lifespan = "48yrs", Occupation = "Military General", Country = "China" },
            //        new Author { Name = "Plato", BirthDate = new DateTime(427, 1, 1), DeathDate = new DateTime(347, 1, 1), Lifespan = "80yrs", Occupation = "Philosopher", Country = "Greece" },
            //        new Author { Name = "Napoleon Bonaparte", BirthDate = new DateTime(1769, 8, 15), DeathDate = new DateTime(1821, 5, 5), Lifespan = "51yrs", Occupation = "Military General", Country = "France" },
            //        new Author { Name = "Adam Smith", BirthDate = new DateTime(1723, 6, 5), DeathDate = new DateTime(1790, 7, 17), Lifespan = "67yrs", Occupation = "Economist", Country = "Scotland" },
            //        new Author { Name = "Immanuel Kant", BirthDate = new DateTime(1724, 4, 22), DeathDate = new DateTime(1804, 2, 12), Lifespan = "79yrs", Occupation = "Philosopher", Country = "Germany" },
            //        new Author { Name = "George Washington", BirthDate = new DateTime(1732, 2, 22), DeathDate = new DateTime(1799, 12, 14), Lifespan = "67yrs", Occupation = "Military General", Country = "USA" },
            //        new Author { Name = "Karl Marx", BirthDate = new DateTime(1818, 5, 5), DeathDate = new DateTime(1883, 3, 14), Lifespan = "64yrs", Occupation = "Philosopher", Country = "Germany" },
            //        new Author { Name = "Alexander the Great", BirthDate = new DateTime(356, 7, 20), DeathDate = new DateTime(323, 6, 10), Lifespan = "33yrs", Occupation = "Military General", Country = "Macedonia" },
            //        new Author { Name = "Thomas Edison", BirthDate = new DateTime(1847, 2, 11), DeathDate = new DateTime(1931, 10, 18), Lifespan = "84yrs", Occupation = "Inventor", Country = "USA" },
            //        new Author { Name = "Confucius", BirthDate = new DateTime(551, 9, 28), DeathDate = new DateTime(479, 11, 24), Lifespan = "72yrs", Occupation = "Philosopher", Country = "China" },
            //        new Author { Name = "Julius Caesar", BirthDate = new DateTime(100, 7, 12), DeathDate = new DateTime(44, 3, 15), Lifespan = "56yrs", Occupation = "Military General", Country = "Rome" },
            //        new Author { Name = "Andrew Carnegie", BirthDate = new DateTime(1835, 11, 25), DeathDate = new DateTime(1919, 8, 11), Lifespan = "83yrs", Occupation = "Businessman", Country = "USA" },
            //        new Author { Name = "Socrates", BirthDate = new DateTime(469, 5, 21), DeathDate = new DateTime(399, 5, 21), Lifespan = "70yrs", Occupation = "Philosopher", Country = "Greece" },
            //        new Author { Name = "Genghis Khan", BirthDate = new DateTime(1162, 11, 14), DeathDate = new DateTime(1227, 8, 18), Lifespan = "65yrs", Occupation = "Military General", Country = "Mongolia" },
            //        new Author { Name = "John D. Rockefeller", BirthDate = new DateTime(1839, 7, 8), DeathDate = new DateTime(1937, 5, 23), Lifespan = "97yrs", Occupation = "Businessman", Country = "USA" },
            //        new Author { Name = "Voltaire", BirthDate = new DateTime(1694, 11, 21), DeathDate = new DateTime(1778, 5, 30), Lifespan = "83yrs", Occupation = "Philosopher", Country = "France" },
            //        new Author { Name = "Marcus Aurelius", BirthDate = new DateTime(121, 4, 26), DeathDate = new DateTime(180, 3, 17), Lifespan = "58yrs", Occupation = "Philosopher", Country = "Rome" },
            //        new Author { Name = "Sun Tzu", BirthDate = new DateTime(544, 1, 1), DeathDate = new DateTime(496, 1, 1), Lifespan = "48yrs", Occupation = "Military General", Country = "China" },
            //        new Author { Name = "Bill Gates", BirthDate = new DateTime(1955, 10, 28), DeathDate = DateTime.Now, Lifespan = "69yrs", Occupation = "Businessman", Country = "USA" }
            //    ];
            //}



        }
    }
}
