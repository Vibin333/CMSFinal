using CMSFinalProject.Models;
using CMSFinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMSFinalProject.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatient _patientService;
        public PatientsController(IPatient patientService)
        {
            _patientService = patientService;
        }
        // GET: PatientsController
        public ActionResult Index(Patient patient)
        {
            return RedirectToAction(nameof(List));
        }

        public ActionResult List()
        {
            List<Patient> patients = _patientService.GetAllPatients();
            return View(patients);
        }

        // GET: PatientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Patient patient)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _patientService.AddPatient(patient);
                    // Code to save the patient to the database would go here

                }
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientsController/Edit/5
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

        // GET: PatientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientsController/Delete/5
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
