using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mortaltig.Domain.Models;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Interfaces
{
    public interface IRoadMap
    {
        Task<RoadMap> CreateRoadMap(RoadMap req);

        Task<RoadMap> GetRoadMap(int Id);
        Task<RoadMap> UpdateRoadMap(int Id);

        Task<RoadMap> GetRoadMaps();
    }
}
