using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TC.DatabaseContext;

namespace DbInstaller
{
    public class DbContextFactory : IDesignTimeDbContextFactory<TemperatureConverterDbContext>
    {
        public TemperatureConverterDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TemperatureConverterDbContext>();
            // IMPORTANT:
            // THIS Should be read from appsettings.json/configuration really :/
            // HOWEVER, YOU MUST CHANGE THIS dbConnString to match the appsettings.json in the APIClient project.
            // ADDED IT HERE, NOT TO CLUTTER THE DBContext Projects with generated EF Migration files
            var dbConnString = "Host =localhost; Username =soni; Password =spyderman2; Database =cube-dev;";
            optionsBuilder.UseNpgsql(dbConnString, e => e.MigrationsAssembly("DbInstaller"));
            return new TemperatureConverterDbContext(optionsBuilder.Options);
        }
    }
}

