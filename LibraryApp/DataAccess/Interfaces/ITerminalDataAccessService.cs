using LibraryApp.Models;

namespace LibraryApp.DataAccess.Interfaces
{
    public interface ITerminalDataAccessService
    {
        public List<Terminal> GetTerminals();
        public Terminal GetTerminal(Guid terminal);
    }
}
