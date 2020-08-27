using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.BusinessEntities;

namespace Repositories.Interfaces
{
    class FlightRepositoryImpl : IFlightRepository
    {
        public void CreateFlight(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void Delete(Flight flight)
        {
            throw new NotImplementedException();
        }

        public Flight QueryFlightByFlightNumber(string flightNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> QueryFlights(Expression<Func<Flight, bool>> queryExpression)
        {
            throw new NotImplementedException();
        }
    }
}
