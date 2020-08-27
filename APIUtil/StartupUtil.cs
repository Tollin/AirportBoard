

namespace APIUtil
{
    using DTO;
    using Entities.BusinessEntities;
    using Microsoft.Extensions.DependencyInjection;
    using Repositories.Interfaces;

    /// <summary>
    /// Defines the <see cref="StartupUtil" />.
    /// </summary>
    public static class StartupUtil
    {
        /// <summary>
        /// The RegisterService.
        /// </summary>
        /// <param name="service">The service<see cref="IServiceCollection"/>.</param>
        public static void RegisterService(this IServiceCollection service)
        {
            Repositories.ServiceRegister.RegisterService(service);
            Services.ServiceRegister.RegisterService(service);
        }

        /// <summary>
        /// The RegisterExpressMapper.
        /// </summary>
        public static void RegisterExpressMapper()
        {
            ExpressMapper.Mapper.Register<Flight, FlightModel>();
            ExpressMapper.Mapper.Register<FlightModel, Flight>();
        }
    }
}
