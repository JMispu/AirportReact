using DAL.Context;
using DAL.Repositories;
using System;
using System.Threading.Tasks;

namespace BLL
{
    public class UnitOfWork : IUnitOfWork
    {
        private AirportContext DB;

        public UnitOfWork(AirportContext dB)
        {
            DB = dB;
        }

        private FlightRepos Fligt;
        public FlightRepos Flights => Fligt ??= new FlightRepos(DB);

        public AirplaneRepos Airplan;
        public AirplaneRepos Airplans => Airplan ??= new AirplaneRepos(DB);

        public CityRepos City;
        public CityRepos Cities => City ??= new CityRepos(DB);

        public void Dispose()
        {
            DB.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Exception> Save()
        {
            try { await DB.SaveChangesAsync(); }
            catch(Exception ex) { return ex; }
            return null;
        }
    }
}
