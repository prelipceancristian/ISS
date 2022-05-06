using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;

namespace LibraryApp.DataAccess
{
    public class BookDataAccessService : IBookDataAccessService
    {
        AppContext _context;

        public BookDataAccessService(AppContext context)
        {
            _context = context;
        }

        public Book GetBookById(Guid id)
        {
            return _context.Books.FirstOrDefault(x => x.ID == id);
        }
    }
}
