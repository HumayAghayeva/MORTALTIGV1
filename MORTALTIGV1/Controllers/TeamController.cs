using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MORTALTIGV1.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace MORTALTIGV1.Controllers
{
    public class TeamController : Controller
    {
        public readonly Conn _dbContext;

        public TeamController(Conn dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: TeamController1
        public ActionResult Index()
        {

            ViewBag.Team = _dbContext.Set<Team>().ToList();
            return View(ViewBag.Team);
        }

        // GET: TeamController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Team team, IFormFile file)
        {
            try
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var fileContent = reader.ReadToEnd();
                    var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                    team.PhotoUrl = parsedContentDisposition.FileName;
                }
                _dbContext.Add<Team>(team);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamController1/Edit/5
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

        // GET: TeamController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamController1/Delete/5
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
