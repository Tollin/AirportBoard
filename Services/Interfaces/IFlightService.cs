using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace Services.Interfaces
{
    public interface IFlightService
    {
        FlightModel GetFlightByFlightNumber(string flightNumber);

        void FlightBoarding(string flightNumber, string gateNumber);
    }
}
