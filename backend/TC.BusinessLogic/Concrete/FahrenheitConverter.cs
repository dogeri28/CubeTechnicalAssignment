using System;
using TC.BusinessLogic.Abstract;
using TC.DTOModels;

namespace TC.BusinessLogic.Concrete
{
    public class FahrenheitConverter : IConvertFahrenheit
    {
        public TemperatureConvertResponse Convert(TemperatureConvertRequest request)
        {

            switch (request.TemperatureTypeTo)
            {
                case Models.TemperatureType.Celsius:
                    return ConvertToCelsius(request);

                case Models.TemperatureType.Kelvin:
                    return ConvertToKelvin(request);
            }

            throw new Exception("Invalid type to convert");
        }

        private TemperatureConvertResponse ConvertToCelsius(TemperatureConvertRequest request)
        {
            var fahrenheit = request.TemperatureValueFrom ?? -1;
            var celsius = (fahrenheit - 32) * 5 / 9; ;

            return new TemperatureConvertResponse()
            {
                TemperatureValueFrom = fahrenheit,
                TemperatureValueTo = celsius,
                TemperatureTypeFrom = (int)request.TemperatureTypeFrom,
                TemperatureTypeTo = (int)request.TemperatureTypeTo
            };
        }

        private TemperatureConvertResponse ConvertToKelvin(TemperatureConvertRequest request)
        {
            var fahrenheit = request.TemperatureValueFrom ?? -1;
            var kelvin = (decimal) (273.5M + ((fahrenheit - 32.0M) * (5.0M / 9.0M)));

            return new TemperatureConvertResponse()
            {
                TemperatureValueFrom = fahrenheit,
                TemperatureValueTo = kelvin,
                TemperatureTypeFrom = (int)request.TemperatureTypeFrom,
                TemperatureTypeTo = (int)request.TemperatureTypeTo
            };
        }
    }
}

