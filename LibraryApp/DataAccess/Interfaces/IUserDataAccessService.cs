using LibraryApp.Models;

namespace LibraryApp.DataAccess.Interfaces
{
    public interface IUserDataAccessService
    {
        public User GetUser(string username, string password);
    }
}
