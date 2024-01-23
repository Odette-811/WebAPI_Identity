using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_6._0.Models
{
    public class PageDto
    {
        [Required]
        public  int Id { get; set; }
        [Required]
        public  string? Title { get; set; }
        [Required]
        public  string? Body { get; set; }
        [Required]
        public  string? Author { get; set; }
    }
}
