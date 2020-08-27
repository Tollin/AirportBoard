using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Entities.BusinessEntities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class FlightContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        private const string ConnectionStringKey = "DefaultConnectionString";

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseMySQL(ConfigurationManager.ConnectionStrings[ConnectionStringKey].ConnectionString);
    }
}
