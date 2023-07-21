using Fitness_Web.Data;
using Fitness_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Web.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var races = _context.Races.ToList();
            return View(races);
        }
        public IActionResult Details(int id)
        {
            Race race = _context.Races.Include(a => a.Address).SingleOrDefault(r => r.Id == id);
            return View(race);
        }
    }
}
