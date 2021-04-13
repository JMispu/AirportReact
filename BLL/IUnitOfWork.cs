using System;
using System.Threading.Tasks;
using DAL.Repositories;

namespace BLL
{
    public interface IUnitOfWork : IDisposable
    {
        FlightRepos Flights { get; }
        AirplaneRepos Airplans { get; }
        CityRepos Cities { get; }

        public Task<Exception> Save();
    }
}
