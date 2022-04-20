using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models
{
    public class BookCopy
    {
        public Guid Id { get; set; }

        [ForeignKey("Books")]
        public Guid BookId { get; set; }

        [ForeignKey("Users")]
        public Guid? UserId { get; set; }

        [ForeignKey("Terminals")]
        public Guid? TerminalId { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
