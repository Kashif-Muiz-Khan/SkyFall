using Microsoft.AspNetCore.Identity;

namespace SkyFall.Model
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public List<ToDoList> ToDoLists { get; set; } = [];
    }
}
