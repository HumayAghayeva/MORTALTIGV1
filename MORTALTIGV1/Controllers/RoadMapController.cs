using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mortaltig.Domain.Models;
using Mortaltig.Infrastructure.Repositories;
using MORTALTIGV1.Models;

namespace MORTALTIGV1.Controllers
{
    public class RoadMapController : Controller
    {
        public readonly IRoadMapRepository _roadMapRepository;
        public RoadMapController(IRoadMapRepository roadMapRepository)
        {
            _roadMapRepository = roadMapRepository;
        }


        // GET: RoadMapController
        public async Task<ActionResult> Index()
        {
            ViewBag.maps = await _roadMapRepository.ListAsync();
            return View(ViewBag.maps);
        }

        // GET: RoadMapController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoadMapController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: RoadMapController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RoadMap map)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _roadMapRepository.AddAsync(map);
                    return RedirectToAction("Index");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoadMapController/Edit/5
        

        // POST: RoadMapController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public async Task<ActionResult> Createtest()
        {
            return View();
        }
    }
}
