using Microsoft.AspNetCore.Mvc;

namespace Fitness_Web.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
