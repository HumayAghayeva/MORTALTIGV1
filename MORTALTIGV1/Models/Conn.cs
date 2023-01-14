using Microsoft.EntityFrameworkCore;
using MORTALTIGV1.Models;

namespace MORTALTIGV1.Models
{
    public class Conn : DbContext
    {
        public Conn(DbContextOptions<Conn> options) : base(options)
        {
        }
        DbSet<FAQ> FAQs { get; set; }
        DbSet<RoadMap> RoadMaps { get; set; }
        DbSet<Team> Teams { get; set; }
    }
}
