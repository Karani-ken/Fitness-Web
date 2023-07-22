using Fitness_Web.Models;

namespace Fitness_Web.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetByIdAsync(int id);
        Task<IEnumerable<Club>> GetClubByCity(string city);
        bool Add(Club club);
        Task Update(Club club);
        Task Delete(Club club);
        bool Save();
    }
}
