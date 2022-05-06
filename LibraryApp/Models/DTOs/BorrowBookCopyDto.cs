namespace LibraryApp.Models.DTOs
{
    public class BorrowBookCopyDto
    {
        public BorrowBookCopyDto() { }
        public Guid BookCopyId;
        public Guid UserId;
        public DateTime Deadline;
    }
}
