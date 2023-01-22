using Microsoft.AspNetCore.Mvc;
using Mortaltig.Infrastructure.Repositories;

namespace MORTALTIGV1.Components
{
    public class RoadMapViewComponent:ViewComponent
    {
        private IRoadMapRepository _roadMapRepository { get;}
        public  RoadMapViewComponent(IRoadMapRepository roadMapRepository)
        {
            this._roadMapRepository = roadMapRepository;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            var roadMap = _roadMapRepository.GetAllList();
            return Task.FromResult<IViewComponentResult>(View(roadMap));
        }
    }
}
