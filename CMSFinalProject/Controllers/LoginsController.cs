using CMSFinalProject.Services;
using CMSFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CMSFinalProject.Controllers
{
    public class LoginsController : Controller
    {
        private readonly ILoginService _loginService;
        public LoginsController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Title"] = "Credentials";
            return View(new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _loginService.Login(loginViewModel.Username, loginViewModel.Password);
                if (user != null)
                {
                    Response.Cookies.Append("UserId", user.UserId.ToString());
                    Response.Cookies.Append("RoleId", user.RoleId.ToString());
                    TempData["SuccessMessage"] = "Login successful!";
                    // Successful login logic here
                    return RedirectToRoleBasedDashBoard(user.RoleId);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }
            return View(loginViewModel);
        }
        public IActionResult RedirectToRoleBasedDashBoard(int? roleId)
        {
            switch (roleId)
            {
                case 1: // Admin
                    return RedirectToAction("Index", "Patients");
                case 2: // Doctor
                    return RedirectToAction("Index", "Doctors");
                case 3: // Nurse
                    return RedirectToAction("Index", "Pharmacists");
                case 4: // Patient
                    return RedirectToAction("Index", "LabTechs");
                case 5: // Lab Technician
                    return RedirectToAction("Index", "Admins");
                default:
                    return RedirectToAction("Login", "Logins");
            }
        }

    }
}
