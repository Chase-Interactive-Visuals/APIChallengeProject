using APIChallengeProject.Models;

namespace APIChallengeProject.Interfaces
{
    public interface IAircraftRepository
    {
        ICollection<Aircraft> GetAircrafts();
        Aircraft GetAircraftById(int id);
        bool AircraftExist(int aircraftID);
    }
}
