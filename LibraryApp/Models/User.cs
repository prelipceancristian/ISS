namespace LibraryApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string CNP { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<BookCopy> BookCopies { get; set; }
    }
}
