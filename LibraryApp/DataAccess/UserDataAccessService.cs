using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess
{
    public class UserDataAccessService : IUserDataAccessService
    {
        AppContext _context;

        public UserDataAccessService(AppContext context)
        {
            _context = context;
        }

        public User GetUser(string username, string password)
        {
            return _context.Users.Include(x => x.BookCopies).Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
