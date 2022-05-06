using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess
{
    public class BookCopyDataAccessService : IBookCopyDataAccessService
    {
        AppContext _context;

        public BookCopyDataAccessService(AppContext context)
        {
            _context = context;
        }
        public List<BookCopy> GetBookCopies()
        {
            return _context.BookCopies.ToList();
        }

        public List<BookCopy> GetBookCopiesByTerminal(Guid terminalId)
        {
            return _context.BookCopies.Where(c => c.TerminalId == terminalId).ToList();
        }

        public BookCopy GetBookCopy(Guid bookCopyId)
        {
            return _context.BookCopies.FirstOrDefault(x => x.Id == bookCopyId);
        }

        public void UpdateBookCopy(BookCopy bookCopy)
        {
            _context.BookCopies.Update(bookCopy);
        }
    }
}
