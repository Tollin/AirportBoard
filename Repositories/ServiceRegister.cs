using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;

namespace Repositories
{
    public class ServiceRegister
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddTransient<IFlightRepository, FlightRepositoryImpl>();
        }
    }
}
