namespace ASP.NET_Core_6._0.Models
{
    public class AuthResponse
    {
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string Username { get; internal set; }
    }
}
