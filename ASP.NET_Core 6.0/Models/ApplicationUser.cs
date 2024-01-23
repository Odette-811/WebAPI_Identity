using ASP.NET_Core_6._0.Enums;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_6._0.Models;


public class ApplicationUser : IdentityUser
{
    public Role Role { get; set; }
}