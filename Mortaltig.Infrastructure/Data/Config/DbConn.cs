using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mortaltig.Infrastructure.Data.Config
{
    public class DbConn : DbContext
    {

        public DbConn(DbContextOptions<DbContext> options) : base(options)
        {
        }
    }

}
