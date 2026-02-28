using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementSystem.MVC.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
