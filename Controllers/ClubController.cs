using Fitness_Web.Data;
using Fitness_Web.Interfaces;
using Fitness_Web.Models;
using Fitness_Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Web.Controllers
{
    public class ClubController : Controller
    {
       
        private readonly IClubRepository _clubRepository;
        private readonly IPhotoService _photoService;
        public ClubController(IClubRepository clubRepository, IPhotoService photoService)
        {
                _clubRepository = clubRepository;
                _photoService = photoService;
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
        public async Task<IActionResult> Create(CreateClubViewModel clubVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(clubVm.Image);
                var club = new Club
                {
                    Title = clubVm.Title,
                    Description = clubVm.Description,
                    Image = result.Url.ToString(),
                    Address= new Address
                    {
                        Street=clubVm.Address.Street,
                        City=clubVm.Address.City,
                        County=clubVm.Address.County
                    }
                };
                _clubRepository.Add(club);

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }

            return View(clubVm);
           
        }
    }
}
