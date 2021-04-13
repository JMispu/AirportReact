using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class AirplaneRepos : AbstractRepository<Airplane>
    {
        public AirplaneRepos(AirportContext context) : base(context.Airplane, context) { }
    }

    public class CityRepos : AbstractRepository<City>
    {
        public CityRepos(AirportContext context) : base(context.City, context) { }
    }

    public class FlightRepos : AbstractRepository<Flight>
    {
        public FlightRepos(AirportContext context) : base(context.Flight, context) { }
        public override void UpdateItem(Flight item)
        {
            Flight f = DBset.Find(item.ID);
            if(f != null)
            {
                f.AirplaneID = item.AirplaneID;
                f.StartCityID = item.StartCityID;
                f.FinishCityID = item.FinishCityID;
                f.Time = item.Time;
            }
            base.UpdateItem(f);
        }
    }
}
