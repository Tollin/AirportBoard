using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.BusinessEntities;

namespace Repositories.Interfaces
{
    public interface IFlightRepository
    {
        void CreateFlight(Flight flight);

        void Delete(Flight flight);

        Flight QueryFlightByFlightNumber(string flightNumber);

        IEnumerable<Flight> QueryFlights(Expression<Func<Flight, bool>> queryExpression);

        void UpdateFlight(Flight flight);
    }
}
