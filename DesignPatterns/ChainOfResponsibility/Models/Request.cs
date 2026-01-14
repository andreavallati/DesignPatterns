namespace ChainOfResponsibility.Models
{
    public class Request
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Resource { get; set; } = string.Empty;
        public bool IsAuthenticated { get; set; }
        public bool IsAuthorized { get; set; }
    }
}
