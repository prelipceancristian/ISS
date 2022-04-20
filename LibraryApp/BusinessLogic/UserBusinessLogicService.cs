using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;

namespace LibraryApp.BusinessLogic
{
    public class UserBusinessLogicService : IUserBusinessLogicService
    {
        IUserDataAccessService _userDataAccessService;

        public UserBusinessLogicService(IUserDataAccessService userDataAccessService)
        {
            _userDataAccessService = userDataAccessService;
        }

        public (User user, bool isValid) Login(string username, string password)
        {
            var userEntity = _userDataAccessService.GetUser(username, password);
            if(userEntity != null)
            {
                return (userEntity, true);
            }
            return (null, false);
        }
    }
}
