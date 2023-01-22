using Mortaltig.Domain.Interfaces;
using Mortaltig.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Services
{
    public class TeamMemberServices : ITeamMembers
    {
        public Task<TeamMembers> CreateTeamMember(TeamMembers teamMember)
        {
            throw new NotImplementedException();
        }

        public Task<TeamMembers> GetTeamMember(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<TeamMembers> GetTeamMembers()
        {
            throw new NotImplementedException();
        }

        public Task<TeamMembers> UpdateTeamMember(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
