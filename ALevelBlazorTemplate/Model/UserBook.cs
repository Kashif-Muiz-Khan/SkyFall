namespace SkyFall.Model
{
    public class UserBook
    {
        public int UserBookID { get; set; }
        public User UserID { get; set; }
        public Book BookID { get; set; }
        public string ReadStatus { get; set; }
    }
}
