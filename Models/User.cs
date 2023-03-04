namespace MySixteenWeb.Models
{
    public class User
    {
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Bio { get; set; }
        public string Headline { get; set; }
        public bool Verified { get; set; }
    }
}