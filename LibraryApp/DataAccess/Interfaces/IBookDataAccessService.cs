using LibraryApp.Models;

namespace LibraryApp.DataAccess.Interfaces
{
    public interface IBookDataAccessService
    {
        public Book GetBookById(Guid id);
    }
}
