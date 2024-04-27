namespace SkyFall.Model
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public string Lifespan { get; set; }
        public string Occupation { get; set; }
        public string Country { get; set; }

        public List<Book> Books { get; set; } = [];
        public List<Quote> Quotes { get; set; } = [];
    }
}
