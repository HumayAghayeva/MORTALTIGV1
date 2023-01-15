using Mortaltig.Domain.Models;
using Mortaltig.Infrastructure.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Infrastructure.Repositories
{
    public class RoadMapRepository : Repository<RoadMap>, IRoadMapRepository
    {
        public RoadMapRepository(DbConn context) : base(context)
        {
        }
    }
}
