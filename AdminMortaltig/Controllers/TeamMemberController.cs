using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mortaltig.Domain.Models;
using Mortaltig.Infrastructure.Repositories;
using Microsoft.AspNetCore.Hosting;

namespace AdminMortaltig.Controllers
{
    public class TeamMemberController : Controller
    {
        public readonly ITeamMembersRepository _teamMembers;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public TeamMemberController(ITeamMembersRepository teamMembers, IWebHostEnvironment hostingEnvironment)
        {
            _teamMembers = teamMembers;
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: TeamMembers
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamMembers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamMembers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamMembers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TeamMembers teamMembers)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (teamMembers.Photo != null)
                    {
                        var name = Path.Combine(_hostingEnvironment.WebRootPath + "/MemberPhotos", Path.GetFileName(teamMembers.Photo.FileName));
                        await teamMembers.Photo.CopyToAsync(new FileStream(name, FileMode.Create));
                        teamMembers.PhotoUrl = teamMembers.Photo.FileName;
                    }
                    await _teamMembers.AddAsync(teamMembers);
                    return RedirectToAction("Index");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamMembers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamMembers/Edit/5
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

        // GET: TeamMembers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamMembers/Delete/5
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
