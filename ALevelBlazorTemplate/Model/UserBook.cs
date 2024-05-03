namespace SkyFall.Model
{
    public class UserBook
    {
        public int UserBookID { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public string ReadStatus { get; set; }
    }
}
