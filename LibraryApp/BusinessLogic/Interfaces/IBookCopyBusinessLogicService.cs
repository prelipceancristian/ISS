using LibraryApp.Models;

namespace LibraryApp.BusinessLogic.Interfaces
{
    public interface IBookCopyBusinessLogicService
    {
        public List<BookCopy> GetBookCopies();
        public List<BookCopy> GetBookCopiesByTerminal(Guid terminalId);
    }
}
