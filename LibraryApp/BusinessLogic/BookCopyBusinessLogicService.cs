using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.BusinessLogic.Models;
using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;

namespace LibraryApp.BusinessLogic
{
    public class BookCopyBusinessLogicService : IBookCopyBusinessLogicService
    {
        IBookCopyDataAccessService _bookCopyDataAccessService;
        IBookDataAccessService _bookDataAccessService;

        public BookCopyBusinessLogicService(IBookCopyDataAccessService bookCopyDataAccessService, IBookDataAccessService bookDataAccessService)
        {
            _bookCopyDataAccessService = bookCopyDataAccessService;
            _bookDataAccessService = bookDataAccessService;
        }

        public bool BorrowBook(Guid bookCopyId, Guid userId, DateTime dueDate)
        {
            var bookCopy = _bookCopyDataAccessService.GetBookCopy(bookCopyId);
            if(bookCopy == null)
            {
                return false;
            }
            if(bookCopy.UserId != null)
            {
                return false;
            }
            bookCopy.UserId = userId;
            bookCopy.ReturnDate = dueDate;
            _bookCopyDataAccessService.UpdateBookCopy(bookCopy);
            return true;
        }

        public List<BookCopyBusinessObject> GetBookCopies()
        {
            var bookCopies = new List<BookCopyBusinessObject>();

            foreach (var bookCopy in _bookCopyDataAccessService.GetBookCopies())
            {
                var bookCopyBusinessObject = new BookCopyBusinessObject(bookCopy);
                bookCopyBusinessObject.Book = _bookDataAccessService.GetBookById(bookCopyBusinessObject.BookId);
                bookCopies.Add(bookCopyBusinessObject);
            }

            return bookCopies;
        }

        public List<BookCopy> GetBookCopiesByTerminal(Guid terminalId)
        {
            return _bookCopyDataAccessService.GetBookCopiesByTerminal(terminalId);
        }
    }
}
