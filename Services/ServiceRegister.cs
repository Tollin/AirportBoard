using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Interfaces.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ServiceRegister
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddTransient<IFlightService, FlightServiceImpl>();
        }
    }
}
