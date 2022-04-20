namespace LibraryApp.Models
{
    public class Terminal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<BookCopy> BookCopies { get; set; }
    }
}
