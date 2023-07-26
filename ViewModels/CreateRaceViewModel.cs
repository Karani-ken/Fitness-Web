using Fitness_Web.Data.Enum;
using Fitness_Web.Models;

namespace Fitness_Web.ViewModels
{
    public class CreateRaceViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public RaceCategory RaceCategory { get; set; }
    }
}
