using CMSFinalProject.Models;
using CMSFinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CMSFinalProject.Controllers
{
    public class AdminsController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminsController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        // GET: AdminsController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<User> staffs = _adminService.GetAllStaff();
            return View(staffs);
        }
        // GET: AdminsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminsController/Create
        // GET: AdminsController/Create
        public ActionResult Create()
        {
            // Fixed roles for dropdown
            ViewBag.Roles = new List<SelectListItem>
    {
        new SelectListItem { Text = "Receptionist", Value = "1" },
        new SelectListItem { Text = "Doctor", Value = "2" },
        new SelectListItem { Text = "Admin", Value = "3" },
        new SelectListItem { Text = "Pharmacist", Value = "4" },
        new SelectListItem { Text = "Lab Technician", Value = "5" }
    };

            // Fixed / simple dropdowns for doctor-specific fields
            ViewBag.Specializations = new List<SelectListItem>
    {
        new SelectListItem { Text = "Cardiology", Value = "1" },
        new SelectListItem { Text = "Neurology", Value = "2" },
        new SelectListItem { Text = "Dermatology", Value = "3" }
    };

            ViewBag.Departments = new List<SelectListItem>
    {
        new SelectListItem { Text = "OPD", Value = "1" },
        new SelectListItem { Text = "ER", Value = "2" },
        new SelectListItem { Text = "Pharmacy", Value = "3" }
    };

            return View();
        }


        // POST: AdminsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _adminService.AddStaff(user);
                    // Code to save the patient to the database would go here

                }
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminsController/Edit/5
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

        // GET: AdminsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminsController/Delete/5
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
