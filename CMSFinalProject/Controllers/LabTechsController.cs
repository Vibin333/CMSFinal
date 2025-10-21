using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMSFinalProject.Controllers
{
    public class LabTechsController : Controller
    {
        // GET: LabTechsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LabTechsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LabTechsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LabTechsController/Create
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

        // GET: LabTechsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LabTechsController/Edit/5
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

        // GET: LabTechsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LabTechsController/Delete/5
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
