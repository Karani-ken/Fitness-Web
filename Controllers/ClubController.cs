using Fitness_Web.Data;
using Fitness_Web.Interfaces;
using Fitness_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Web.Controllers
{
    public class ClubController : Controller
    {
       private readonly ApplicationDbContext _context;
        private readonly IClubRepository _clubRepository;
        public ClubController(IClubRepository clubRepository)
        {
                _clubRepository = clubRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs);
        }
        public async Task<IActionResult> Details(int Id)
        {
            Club club = await _clubRepository.GetByIdAsync(Id);
            return View(club);
        }
        public IActionResult Create()
        {
            return View();
        }
        //add a club
        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid)
            {
                return View(club);
            }
            _clubRepository.Add(club);
            return RedirectToAction("Index");
        }
    }
}
