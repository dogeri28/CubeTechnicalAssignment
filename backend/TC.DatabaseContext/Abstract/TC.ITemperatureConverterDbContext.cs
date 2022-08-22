using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TC.Models;

namespace TC.DatabaseContext
{
    public interface ITemperatureConverterDbContext
    {
        DbContext Context { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TemperatureConversion> TemperatureConversions { get; set; }
    }
}