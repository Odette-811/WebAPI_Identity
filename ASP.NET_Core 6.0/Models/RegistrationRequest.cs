using System.ComponentModel.DataAnnotations;
using ASP.NET_Core_6._0.Enums;

namespace ASP.NET_Core_6._0.Models;

public class RegistrationRequest
{
    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    public Role Role { get; set; }
}