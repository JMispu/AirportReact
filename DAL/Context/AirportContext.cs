using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Context
{
    public class AirportContext : DbContext
    {
        public AirportContext(DbContextOptions options) : base(options)
        {
            this.Itinialize();
        }

        private void Itinialize()
        {
            this.Database.EnsureCreated();
            if (Flight.Any()) return;

            Airplane.Add(new Airplane { Name = "Boing_747" });
            Airplane.Add(new Airplane { Name = "Boing_746" });
            City.Add(new City { Name = "Moscow" });
            City.Add(new City { Name = "London" });
            Flight.Add(new Flight
            {
                AirplaneID = 1,
                StartCityID = 1,
                FinishCityID = 2,
                Time = new System.DateTime(2021, 3, 13, 23, 0, 0)
            });
            Flight.Add(new Flight
            {
                AirplaneID = 2,
                StartCityID = 1,
                FinishCityID = 2,
                Time = new System.DateTime(2021, 3, 13, 23, 0, 0)
            });
            SaveChanges();
        }

        public virtual DbSet<Airplane> Airplane { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
    }
}
