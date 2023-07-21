using Fitness_Web.Data;
using Fitness_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Details(int Id)
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(x => x.Id == Id);
            return View(club);
        }
    }
}
