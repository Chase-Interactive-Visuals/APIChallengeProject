using APIChallengeProject.Data;
using APIChallengeProject.Models;

namespace APIChallengeProject
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Aircrafts.Any())
            {
                var aircrafts = new List<Aircraft>()
                {
                    new Aircraft()
                    {
                        DailyHours = 0.7,
                        CurrentHours = 550,
                        AircraftTasks = new List<AircraftTask>()
                        {

                        }
                        
                    },
                    new Aircraft()
                    {
                        DailyHours = 1.1,
                        CurrentHours = 200,
                        AircraftTasks = new List<AircraftTask>()
                        {

                        }

                    }
                };
                dataContext.Aircrafts.AddRange(aircrafts);
                dataContext.SaveChanges();
            }
        }
    }
}