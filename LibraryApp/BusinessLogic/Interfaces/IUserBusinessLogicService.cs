using LibraryApp.Models;

namespace LibraryApp.BusinessLogic
{
    public interface IUserBusinessLogicService
    {
        public (User user, bool isValid) Login(string username, string password);
    }
}
