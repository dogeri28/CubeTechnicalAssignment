using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TC.Models;

namespace TC.DatabaseContext
{
    public class TemperatureConverterDbContext : DbContext, ITemperatureConverterDbContext
    {
        public TemperatureConverterDbContext(DbContextOptions<TemperatureConverterDbContext> options) : base(options)
        {

        }

        public DbContext Context => this;
        public DbSet<TemperatureConversion> TemperatureConversions { get; set; }
    }
}