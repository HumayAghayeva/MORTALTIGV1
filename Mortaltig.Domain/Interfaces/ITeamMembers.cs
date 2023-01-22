using Mortaltig.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Interfaces
{
    public interface ITeamMembers
    {
        Task<TeamMembers> CreateTeamMember(TeamMembers teamMember);

        Task<TeamMembers> GetTeamMember(int Id);
        Task<TeamMembers> UpdateTeamMember(int Id);

        Task<TeamMembers> GetTeamMembers();
    }
}
