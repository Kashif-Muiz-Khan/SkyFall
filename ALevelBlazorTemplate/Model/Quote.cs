namespace SkyFall.Model
{
    public class Quote
    {
        public int QuoteID { get; set; }
        public string QuoteText { get; set; }
        public Author AuthorID { get; set; }
    }
}
