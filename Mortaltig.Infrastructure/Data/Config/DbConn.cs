using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Mortaltig.Domain.Models;

namespace Mortaltig.Infrastructure.Data.Config
{
    public class DbConn : DbContext
    {

        public DbConn(DbContextOptions<DbConn> options) : base(options)
        {
        }
        public DbSet<RoadMap> RoadMaps { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembers>().Ignore(t => t.Photo);
            base.OnModelCreating(modelBuilder);
        }
    }

}
