using APIChallengeProject.Models;
using Microsoft.EntityFrameworkCore;

namespace APIChallengeProject.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Aircraft>? Aircrafts { get; set; }
        public DbSet<AircraftTask>? AircraftTasks { get; set; }

    }
}
