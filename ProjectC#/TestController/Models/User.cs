namespace TestCore.Models
{

    public class User
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Friend> Friends { get; set; }
    }

}

