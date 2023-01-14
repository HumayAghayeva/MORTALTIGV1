using Microsoft.AspNetCore.Mvc;
using MORTALTIGV1.Models;
using System.Diagnostics;

namespace MORTALTIGV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly Conn _dbContext;
        public HomeController(ILogger<HomeController> logger,Conn dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            Mapping map = new Mapping();
            map.RoadMap = _dbContext.Set<RoadMap>().ToList();
            map.FQ = _dbContext.Set<FAQ>().ToList();
            return View(map);

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