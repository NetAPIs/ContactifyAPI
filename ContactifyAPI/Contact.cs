namespace ContactifyAPI
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Proffesion { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
