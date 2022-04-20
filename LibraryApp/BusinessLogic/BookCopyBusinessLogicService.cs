using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;

namespace LibraryApp.BusinessLogic
{
    public class BookCopyBusinessLogicService : IBookCopyBusinessLogicService
    {
        IBookCopyDataAccessService _bookCopyDataAccessService;

        public BookCopyBusinessLogicService(IBookCopyDataAccessService bookCopyDataAccessService)
        {
            _bookCopyDataAccessService = bookCopyDataAccessService;
        }

        public List<BookCopy> GetBookCopies()
        {
            return _bookCopyDataAccessService.GetBookCopies();
        }

        public List<BookCopy> GetBookCopiesByTerminal(Guid terminalId)
        {
            return _bookCopyDataAccessService.GetBookCopiesByTerminal(terminalId);
        }
    }
}
