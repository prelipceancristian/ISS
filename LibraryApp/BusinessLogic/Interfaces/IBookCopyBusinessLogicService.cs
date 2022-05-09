using LibraryApp.BusinessLogic.Models;
using LibraryApp.Models;

namespace LibraryApp.BusinessLogic.Interfaces
{
    public interface IBookCopyBusinessLogicService
    {
        public List<BookCopyBusinessObject> GetBookCopies();
        public List<BookCopyBusinessObject> GetBookCopiesByTerminal(Guid terminalId);
        public bool BorrowBook(Guid bookCopyId, Guid userId, DateTime dueDate);
    }
}
