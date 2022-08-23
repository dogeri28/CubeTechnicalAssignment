using System;
using TC.BusinessLogic.Abstract;
using TC.DTOModels;

namespace TC.BusinessLogic.Concrete
{
    public class CelsiusConverter :IConvertCelsius 
    {
        public TemperatureConvertResponse Convert(TemperatureConvertRequest request)
        {

            switch (request.TemperatureTypeTo)
            {
                case Models.TemperatureType.Fahrenheit:
                    return ConvertToFarenheit(request);

                case Models.TemperatureType.Kelvin:
                    return ConvertToKelvin(request);
            }

            throw new Exception("Invalid type to convert");
        }

        private TemperatureConvertResponse ConvertToFarenheit(TemperatureConvertRequest request)
        {
            var celsius = request.TemperatureValueFrom ?? -1;
            var fahrenheit = (decimal)( (celsius * 9) / 5 + 32);

            return new TemperatureConvertResponse()
            {
                TemperatureValueFrom = celsius,
                TemperatureValueTo = fahrenheit,
                TemperatureTypeFrom = (int)request.TemperatureTypeFrom,
                TemperatureTypeTo = (int)request.TemperatureTypeTo
            };
        }

        private TemperatureConvertResponse ConvertToKelvin(TemperatureConvertRequest request)
        {
            var celsius = request.TemperatureValueFrom ?? -1;
            var kevin = (celsius + 273.15M);

            return new TemperatureConvertResponse()
            {
                TemperatureValueFrom = celsius,
                TemperatureValueTo = kevin,
                TemperatureTypeFrom = (int)request.TemperatureTypeFrom,
                TemperatureTypeTo = (int)request.TemperatureTypeTo
            };
        }     
    }
}

