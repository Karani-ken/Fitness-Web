using Fitness_Web.Data;
using Fitness_Web.Interfaces;
using Fitness_Web.Models;

namespace Fitness_Web.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext _context;
        public ClubRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Club club)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Club club)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Club> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Task Update(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
