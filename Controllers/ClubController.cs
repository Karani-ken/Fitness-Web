using Fitness_Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Fitness_Web.Controllers
{
    public class ClubController : Controller
    {
       private readonly ApplicationDbContext _context;
        public ClubController(ApplicationDbContext contex)
        {
                _context = contex;
        }
        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}
