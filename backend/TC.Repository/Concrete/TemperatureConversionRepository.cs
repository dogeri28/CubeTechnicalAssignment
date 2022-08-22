using System;
using TC.DatabaseContext;
using TC.DTOModels;
using TC.Models;
using TC.Repository.Abstract;


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

        public TemperatureConversion SaveTemperatureConversion(TemperatureConvertResponse response)
        {
            return HandleSaveTemperatureConversion(response);
        }

        private TemperatureConversion HandleSaveTemperatureConversion(TemperatureConvertResponse response)
        {
            var entity = new TemperatureConversion()
            {
                TemperatureTypeFrom = response.TemperatureTypeFrom,
                TemperatureTypeTo = response.TemperatureTypeTo,
                TemperatureValueFrom = response.TemperatureValueFrom,
                TemperatureValueTo = response.TemperatureValueTo
            };

            _dbContext.TemperatureConversions.Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }
    }
}

