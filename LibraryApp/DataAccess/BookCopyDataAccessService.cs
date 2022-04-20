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
    }
}
