using Microsoft.AspNetCore.Http.HttpResults;

namespace SkyFall.Model
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string DeathDate { get; set; }
        public string Lifespan { get; set; }
        public string Occupation { get; set; }
        public string Country { get; set; }

        public List<Book> BooksAuthored { get; set; } = [];
        public List<Quote> Quotes { get; set; } = [];
    }
}


//based on the following class

//public class Author
//{
//    public string Name { get; set; }
//    public DateTime BirthDate { get; set; }
//    public DateTime DeathDate { get; set; }
//    public string Lifespan { get; set; }
//    public string Occupation { get; set; }
//    public string Country { get; set; }
//}

//create me 20 authors and add them to a list variable in c#. use real authors for the details, use object initialisers for object creation.