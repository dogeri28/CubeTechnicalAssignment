using System;
using TC.DatabaseContext;
using TC.DTOModels;
using TC.Models;
using TC.Repository.Abstract;
using TC.Repository.Helpers;

namespace TC.Repository.Concrete
{
    public class TemperatureConversionRepository : ITemperatureConversionRepository
    {
        #region Dependency Injected fields

        private readonly ITemperatureConverterDbContext _dbContext;

        #endregion


        public TemperatureConversionRepository(ITemperatureConverterDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<TemperatureConversion> SaveTemperatureConversion(TemperatureConvertResponse response)
        {
            return await HandleSaveTemperatureConversion(response);
        }

        private async Task<TemperatureConversion> HandleSaveTemperatureConversion(TemperatureConvertResponse response)
        {
            var entity = new TemperatureConversion()
            {
                TemperatureTypeFrom = (TemperatureType) response.TemperatureTypeFrom,
                TemperatureTypeTo = (TemperatureType) response.TemperatureTypeTo,
                TemperatureValueFrom = response.TemperatureValueFrom,
                TemperatureValueTo = response.TemperatureValueTo
            };

            _dbContext.TemperatureConversions.Add(entity);
            await _dbContext.SaveChangesAsync(default);

            return entity;
        }
    }
 

}

