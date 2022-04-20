using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess
{
    public class TerminalDataAccessService : ITerminalDataAccessService
    {
        AppContext _context;

        public TerminalDataAccessService(AppContext context)
        {
            _context = context;
        }

        public Terminal GetTerminal(Guid terminalId)
        {
            return _context.Terminals.Include(x => x.BookCopies).Where(x => x.Id == terminalId).FirstOrDefault();
        }

        public List<Terminal> GetTerminals()
        {
            return _context.Terminals.Include(x => x.BookCopies).ToList();
        }
    }
}
