using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mortaltig.Domain.Models;
using Mortaltig.Infrastructure.Repositories;

namespace AdminMortaltig.Controllers
{
    public class RoadMapController : Controller
    {
        public readonly IRoadMapRepository _roadMapRepository;
        public RoadMapController(IRoadMapRepository roadMapRepository)
        {
            _roadMapRepository = roadMapRepository;
        }
        // GET: RoadMapController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoadMapController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoadMapController1/Create
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
        // POST: RoadMapController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RoadMapController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoadMapController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RoadMapController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoadMapController1/Delete/5
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
    }
}
