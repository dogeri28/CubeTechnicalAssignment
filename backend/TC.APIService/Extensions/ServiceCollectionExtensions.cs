using System;
using Microsoft.Extensions.DependencyInjection;
using TC.BusinessLogic.Abstract;
using TC.BusinessLogic.Concrete;
using TC.DatabaseContext;
using TC.Repository.Abstract;
using TC.Repository.Concrete;

namespace TC.APIService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTemperatureConverterDBContext(this IServiceCollection services)
        {
          return services.AddTransient<ITemperatureConverterDbContext, TemperatureConverterDbContext>();
        }

        public static IServiceCollection AddTemperatureConvertRepository(this IServiceCollection services)
        {
            return services.AddTransient<ITemperatureConversionRepository, TemperatureConversionRepository>();
        }

        public static IServiceCollection AddTemperatureConvertService(this IServiceCollection services)
        {
            return services.AddTransient<ITemperatureConvertService, TemperatureConvertService>();
        }

        public static IServiceCollection AddCelsiusConverterService(this IServiceCollection services)
        {
            return services.AddTransient<IConvertCelsius, CelsiusConverter>();
        }

        public static IServiceCollection AddFahrenheitConverterService(this IServiceCollection services)
        {
            return services.AddTransient<IConvertFahrenheit, FahrenheitConverter>();
        }

        public static IServiceCollection AddKelvinConverterService(this IServiceCollection services)
        {
            return services.AddTransient<IConvertKelvin, KelvinConverter>();
        }
    }
}

