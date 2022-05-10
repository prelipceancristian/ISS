namespace LibraryApp.Models.DTOs
{
    public class BorrowBookCopyDto
    {
        public Guid BookCopyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Deadline{get;set;}
    }
}
