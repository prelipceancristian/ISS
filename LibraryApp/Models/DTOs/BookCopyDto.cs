using LibraryApp.BusinessLogic.Models;

namespace LibraryApp.Models.DTOs
{
    public class BookCopyDto
    {
        public BookCopyDto(BookCopyBusinessObject bookCopy)
        {
            if(bookCopy != null)
            {
                Id = bookCopy.Id;
                BookId = bookCopy.BookId;
                UserId = bookCopy.UserId;
                TerminalId = bookCopy.TerminalId;
                ReturnDate = bookCopy.ReturnDate;
                if (bookCopy.Book != null)
                {
                    Title = bookCopy.Book.Title ?? null;
                    Author = bookCopy.Book.Author ?? null;
                    PublishingHouse = bookCopy.Book.PublishingHouse ?? null;
                    Year = bookCopy.Book.Year;
                }
            }
        }

        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? TerminalId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public int Year { get; set; }
    }
}
