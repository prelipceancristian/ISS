namespace LibraryApp.Models
{
    public class Book
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public int Year { get; set; }

        public ICollection<BookCopy> BookCopies { get; set; }
    }
}
