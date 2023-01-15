using Microsoft.AspNetCore.Mvc;
using Mortaltig.Infrastructure.Repositories;
using MORTALTIGV1.Models;
using System.Diagnostics;

namespace MORTALTIGV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IRoadMapRepository _roadMapRepository;
        public HomeController(ILogger<HomeController> logger, IRoadMapRepository roadMapRepository)
        {
            _logger = logger;
            _roadMapRepository = roadMapRepository;
        }

        public IActionResult Index()
        {
            //map.RoadMap = _dbContext.Set<RoadMap>().ToList();
            //map.FQ = _dbContext.Set<FAQ>().ToList();
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}