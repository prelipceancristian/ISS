using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [ApiController]
    [Route("Terminals")]
    public class TerminalController
    {
        ITerminalBusinessLogicService _terminalBusinessLogicService;
        public TerminalController(ITerminalBusinessLogicService terminalBusinessLogicService)
        {
            _terminalBusinessLogicService = terminalBusinessLogicService;
        }
        
        [HttpGet]
        public List<Terminal> GetTerminals()
        {
            return _terminalBusinessLogicService.GetTerminals();
        }

        [HttpGet]
        [Route("GetById")]
        public Terminal GetTerminal(Guid terminalId)
        {
            var terminal = _terminalBusinessLogicService.GetTerminal(terminalId);
            return terminal != null ? terminal: new Terminal();
        }

    }
}
