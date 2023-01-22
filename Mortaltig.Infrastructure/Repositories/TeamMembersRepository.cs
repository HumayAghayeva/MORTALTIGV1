using Mortaltig.Domain.Models;
using Mortaltig.Infrastructure.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Infrastructure.Repositories
{
    public class TeamMembersRepository : Repository<TeamMembers>, ITeamMembersRepository
    {
        public TeamMembersRepository(DbConn context) : base(context)
        {
        }
    }
}
