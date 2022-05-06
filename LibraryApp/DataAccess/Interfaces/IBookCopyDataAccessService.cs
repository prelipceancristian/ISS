using LibraryApp.Models;

namespace LibraryApp.DataAccess.Interfaces
{
    public interface IBookCopyDataAccessService
    {
        public List<BookCopy> GetBookCopies();
        public List<BookCopy> GetBookCopiesByTerminal(Guid terminalId);
        public BookCopy GetBookCopy(Guid bookCopyId);
        public void UpdateBookCopy(BookCopy bookCopy);
    }
}
