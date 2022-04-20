using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("BookCopies")]
    public class BookCopyController
    {
        IBookCopyBusinessLogicService _bookCopyBusinessLogicService;
        public BookCopyController(IBookCopyBusinessLogicService bookCopyBusinessLogicService)
        {
            _bookCopyBusinessLogicService = bookCopyBusinessLogicService;   
        }

        [HttpGet]
        public List<BookCopy> GetBookCopies()
        {
            return _bookCopyBusinessLogicService.GetBookCopies();
        }

        [Route("GetByTerminalId")]
        [HttpGet]
        public List<BookCopy> GetBookCopiesByTerminal(Guid terminalId)
        {
            return _bookCopyBusinessLogicService.GetBookCopiesByTerminal(terminalId);   
        }
    }
}
