using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.BusinessEntities;

namespace Repositories.Interfaces
{
    class FlightRepositoryImpl : IFlightRepository
    {
        public void CreateFlight(Flight flight)
        {
            using(FlightContext dbContext = new FlightContext())
            {
                dbContext.Add<Flight>(flight);
                dbContext.SaveChanges();
            }
        }

        public void Delete(Flight flight)
        {
            using (FlightContext dbContext = new FlightContext())
            {
                flight.IsValid = false;
                flight.UpdateTime = DateTime.Now;
                dbContext.Update<Flight>(flight);
                dbContext.SaveChanges();
            }
        }

        public Flight QueryFlightByFlightNumber(string flightNumber)
        {
            using (FlightContext dbContext = new FlightContext())
            {
                return dbContext.Flights.Where(_ => _.FlightNumber == flightNumber && _.IsValid == true).FirstOrDefault();
            }
        }

        public IEnumerable<Flight> QueryFlights(Expression<Func<Flight, bool>> queryExpression)
        {
            using (FlightContext dbContext = new FlightContext())
            {
                return dbContext.Flights.Where(queryExpression).Where(_=>_.IsValid);
            }
        }

        public void UpdateFlight(Flight flight)
        {
            using (FlightContext dbContext = new FlightContext())
            {
                dbContext.Update<Flight>(flight);
                dbContext.SaveChanges();
            }
        }
    }
}
