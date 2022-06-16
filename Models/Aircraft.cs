using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APIChallengeProject.Models
{
    public class Aircraft
    {
        [Key]
        public int AircraftId { get; set; }
        public double DailyHours { get; set; }
        public double CurrentHours { get; set; }
        public ICollection<AircraftTask>? AircraftTasks { get; set; }
        /*
        public Aircraft(int aircraftID, double dailyHours, double currentHours)
        {
            AircraftId = aircraftID;
            DailyHours = dailyHours;
            CurrentHours = currentHours;
        }
        */
    }
}
