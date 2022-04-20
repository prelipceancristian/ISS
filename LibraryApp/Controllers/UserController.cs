using LibraryApp.BusinessLogic;
using LibraryApp.Models;
using LibraryApp.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : ControllerBase
    {
        IUserBusinessLogicService _userBusinessLogicService;

        public UserController(IUserBusinessLogicService userBusinessLogicService)
        {
            _userBusinessLogicService = userBusinessLogicService;
        }

        [HttpGet]
        public User Login(string username, string password)
        {
            var result = _userBusinessLogicService.Login(username, password);
            //return new UserLoginDto { isValid = result.isValid, user = result.user };
            return result.isValid ? result.user : new User();
        }
    }
}
