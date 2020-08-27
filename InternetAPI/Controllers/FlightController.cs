using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace InternetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        public IFlightService flightSerivce { get; set; }
        public FlightController(IFlightService service)
        {
            flightSerivce = service;
        }

        [HttpGet("{flightNumber}")]
        public FlightModel QueryFlight(string flightNumber)
        {
            return flightSerivce.GetFlightByFlightNumber(flightNumber);
        }
    }
}
