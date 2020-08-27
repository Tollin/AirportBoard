using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using DTO;
using Entities.BusinessEntities;
using Repositories.Interfaces;

[assembly: InternalsVisibleToAttribute("ServiceTest")]
namespace Services.Interfaces.Impl
{    
    internal class FlightServiceImpl : IFlightService
    {
        private IFlightRepository flightRepository;
        public FlightServiceImpl(IFlightRepository flight)
        {
            flightRepository = flight;
        }
        public FlightModel GetFlightByFlightNumber(string flightNumber)
        {
            return ExpressMapper.Mapper.Map<Flight, FlightModel>(flightRepository.QueryFlightByFlightNumber(flightNumber));
        }

        public void FlightBoarding(string flightNumber, string gateNumber)
        {
            var currentUser = Thread.CurrentPrincipal as CurrentUserModel;
            if(currentUser == null)
            {
                throw new AuthenticationException("not allow");
            }
            if(!string.Equals(currentUser.CurrentFlightNumber, flightNumber, StringComparison.OrdinalIgnoreCase))
            {
                throw new AuthenticationException("not allow");
            }
            var flight = flightRepository.QueryFlightByFlightNumber(flightNumber);
            if (flight == null)
            {
                throw new ArgumentException($"flight:{flightNumber} does not exist");
            }

            flight.StatusEnum = Entities.Enums.FlightStatusEnum.Boarding;
            flight.DepartureGate = gateNumber;
            flightRepository.UpdateFlight(flight);
        }
    }
}
