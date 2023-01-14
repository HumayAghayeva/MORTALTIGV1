using System.ComponentModel.DataAnnotations;

namespace MORTALTIGV1.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? Text { get; set; }
    }
}
