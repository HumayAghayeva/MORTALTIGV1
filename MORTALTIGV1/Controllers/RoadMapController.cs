using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MORTALTIGV1.Models;

namespace MORTALTIGV1.Controllers
{
    public class RoadMapController : Controller
    {
        public readonly Conn _dbContext;

        public RoadMapController(Conn dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: RoadMapController
        public ActionResult Index()
        {
            ViewBag.maps = _dbContext.Set<RoadMap>().ToList();
            return View(ViewBag.maps);
        }

        // GET: RoadMapController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoadMapController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoadMapController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoadMap map)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Add<RoadMap>(map);
                    _dbContext.SaveChanges();
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
        public ActionResult Edit(int id)
        {
            var change = _dbContext.Set<RoadMap>().FirstOrDefault(w => w.Id == id);
            return View(change);
        }

        // POST: RoadMapController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RoadMap map, int id)
        {
            try
            {
                var change = _dbContext.Set<RoadMap>().FirstOrDefault(w => w.Id == id);
                change.Text = map.Text;
                change.Index = map.Index;
                change.IndexName = map.IndexName;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RoadMapController/Delete/5
        public ActionResult Delete(int id)
        {

            var change = _dbContext.Set<RoadMap>().FirstOrDefault(w => w.Id == id);
            _dbContext.Remove<RoadMap>(change);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

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
    }
}
