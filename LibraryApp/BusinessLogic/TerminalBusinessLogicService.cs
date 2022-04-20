using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;

namespace LibraryApp.BusinessLogic
{
    public class TerminalBusinessLogicService : ITerminalBusinessLogicService
    {
        ITerminalDataAccessService _terminalDataAccessService;

        public TerminalBusinessLogicService(ITerminalDataAccessService terminalDataAccessService)
        {
            _terminalDataAccessService = terminalDataAccessService;
        }

        public Terminal GetTerminal(Guid id)
        {
            var terminal = _terminalDataAccessService.GetTerminal(id);
            return terminal;
        }

        public List<Terminal> GetTerminals()
        {
           return _terminalDataAccessService.GetTerminals();
        }
    }
}
