using System.ComponentModel.DataAnnotations;
namespace MORTALTIGV1.Models
{
    public class Team
    {

        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Profession { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
