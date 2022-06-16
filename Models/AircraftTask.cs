using System.ComponentModel.DataAnnotations;

namespace APIChallengeProject.Models
{
    [System.Serializable]
    public class AircraftTask
    {
        [Key]
        public int ItemNumber { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime LogDate { get; set; }
        public int? LogHours { get; set; } = null;
        public int? IntervalMonths { get; set; } = null;
        public int? IntervalHours { get; set; } = null;
        public DateTime? NextDue { get; set; } = null;

    }
    
}
  