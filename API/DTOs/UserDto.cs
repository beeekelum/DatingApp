namespace API.DTOs
{
    //object returned when user logs in the system
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
}