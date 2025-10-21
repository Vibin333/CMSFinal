using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMSFinalProject.Controllers
{
    public class PharmacistsController : Controller
    {
        // GET: PharmacistsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PharmacistsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PharmacistsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PharmacistsController/Create
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

        // GET: PharmacistsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PharmacistsController/Edit/5
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

        // GET: PharmacistsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PharmacistsController/Delete/5
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
