using APIChallengeProject.Data;
using APIChallengeProject.Interfaces;
using APIChallengeProject.Models;

namespace APIChallengeProject.Repository
{
    public class AircraftRepository : IAircraftRepository
    {
        private readonly DataContext _context;

        public AircraftRepository(DataContext context)
        {
            _context = context;
        }

        public bool AircraftExist(int aircraftID)
        {
            return _context.Aircrafts.Any(a => a.AircraftId == aircraftID);
        }

        public Aircraft GetAircraftById(int id)
        {
            return _context.Aircrafts.Where(a => a.AircraftId == id).FirstOrDefault();
        }

        public ICollection<Aircraft> GetAircrafts()
        {
            return _context.Aircrafts.OrderBy(a => a.AircraftId).ToList();
        }
    }
}
