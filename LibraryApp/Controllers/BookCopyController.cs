using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.Models;
using LibraryApp.Models.DTOs;
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
        public List<BookCopyDto> GetBookCopies()
        {
            var bookCopies = _bookCopyBusinessLogicService.GetBookCopies();
            return bookCopies.Select(x => new BookCopyDto(x)).ToList();
        }

        [Route("GetByTerminalId")]
        [HttpGet]
        public List<BookCopyDto> GetBookCopiesByTerminal(Guid terminalId)
        {
            return _bookCopyBusinessLogicService.GetBookCopiesByTerminal(terminalId).ToList().Select(x => new BookCopyDto(x)).ToList();   
        }

        [HttpPost]
        public bool BorrowBook(BorrowBookCopyDto borrowBookCopyDto)
        {
            return _bookCopyBusinessLogicService.BorrowBook(borrowBookCopyDto.BookCopyId, borrowBookCopyDto.UserId, borrowBookCopyDto.Deadline);
        }
    }
}
