using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace IntranetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private IFlightService flightService;
        public FlightController(IFlightService service)
        {
            flightService = service;
        }
        [HttpPut("boarding/{flightNumber}/{getNumber}")]
        public void FlightBoarding(string flightNumber, string gateNumber)
        {
            flightService.FlightBoarding(flightNumber, gateNumber);
        }
    }
}
