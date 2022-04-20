using LibraryApp.Models;

namespace LibraryApp.BusinessLogic.Interfaces
{
    public interface ITerminalBusinessLogicService
    {
        public Terminal GetTerminal(Guid id);

        public List<Terminal> GetTerminals();
    }
}
