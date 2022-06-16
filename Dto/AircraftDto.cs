using APIChallengeProject.Models;

namespace APIChallengeProject.Dto
{
    public class AircraftDto
    {
        public int AircraftId { get; set; }
        public ICollection<AircraftTask>? AircraftTasks { get; set; }
    }
}
