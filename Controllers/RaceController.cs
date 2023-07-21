using Microsoft.AspNetCore.Mvc;

namespace Fitness_Web.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
