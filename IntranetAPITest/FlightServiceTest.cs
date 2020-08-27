using DTO;
using IntranetAPI.Controllers;
using Moq;
using Repositories.Interfaces;
using Services.Interfaces;
using Services.Interfaces.Impl;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using Xunit;

namespace IntranetAPITest
{
    public class FlightServiceTest
    {
        private IFlightService flightService;
        private Mock<IFlightRepository> flightRepository;

        [Fact]
        public void BoardingTest_When_Update_Non_Self_Flight()
        {
            flightRepository = new Mock<IFlightRepository>();
            flightService = new FlightServiceImpl(flightRepository.Object);
            Thread.CurrentPrincipal = new CurrentUserModel()
            {
                CurrentFlightNumber = "NZ407"
            };

            Assert.Throws<AuthenticationException>(()=>flightService.FlightBoarding("NZ5355", "Gate23"));            
        }
    }
}
