using MORTALTIGV1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
//using MORTALTIG.Protocol.Core.Types;

namespace MORTALTIGV1.Controllers
{
    public class FAQController : Controller
    {
        public readonly Conn _dbContext;

        public FAQController(Conn dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: FAQController
        public ActionResult Index()
        {
            ViewBag.FAQS = _dbContext.Set<FAQ>().ToList();
            return View(ViewBag.FAQS);
        }

        // GET: FAQController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FAQController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FAQController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FAQ faq)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Add<FAQ>(faq);
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

        // GET: FAQController/Edit/5
        public ActionResult Edit(int id)
        {
            var change = _dbContext.Set<FAQ>().FirstOrDefault(w => w.Id == id);
            return View(change);
        }

        // POST: FAQController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FAQ faq,int id)
        {
            try
            {
                var change = _dbContext.Set<FAQ>().FirstOrDefault(w => w.Id == id);
                change.Subject = faq.Subject;
                change.Text = faq.Text;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FAQController/Delete/5
        public ActionResult Delete(int id)
        {
            var change = _dbContext.Set<FAQ>().FirstOrDefault(w => w.Id == id);
            _dbContext.Remove<FAQ>(change);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
