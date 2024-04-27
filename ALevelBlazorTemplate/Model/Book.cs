namespace SkyFall.Model
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        //Author AuthorID { get; set; }
    }
}
