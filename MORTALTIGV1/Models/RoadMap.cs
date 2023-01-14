using System.ComponentModel.DataAnnotations;

namespace MORTALTIGV1.Models
{
    public class RoadMap
    {
        [Key]
        public int Id { get; set; }
        public int Index { get; set; }
        public string? IndexName { get; set; } 
        public string? Text { get; set; }
    }
}
