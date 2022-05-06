namespace LibraryApp.Models.DTOs
{
    public class UserLoginDto
    {
        public UserLoginDto() { }
        public User user { get; set; }
        public bool isValid { get; set; }
    }
}
