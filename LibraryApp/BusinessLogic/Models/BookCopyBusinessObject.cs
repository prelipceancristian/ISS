using LibraryApp.Models;

namespace LibraryApp.BusinessLogic.Models
{
    public class BookCopyBusinessObject: BookCopy
    {
        public BookCopyBusinessObject(BookCopy entity) {
            if(entity != null)
            {
                Id = entity.Id;
                BookId = entity.BookId;
                UserId = entity.UserId;
                TerminalId = entity.TerminalId;
                ReturnDate = entity.ReturnDate;
            }
        }
        public Book Book { get; set; }
    }
}
