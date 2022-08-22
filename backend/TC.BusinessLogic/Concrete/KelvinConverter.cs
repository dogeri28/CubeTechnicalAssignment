using System;
using TC.BusinessLogic.Abstract;
using TC.DTOModels;

namespace TC.BusinessLogic.Concrete
{
    public class KelvinConverter : IConvertKelvin
    {
        public TemperatureConvertResponse? Convert(TemperatureConvertRequest request)
        {

            switch (request.TemperatureTypeTo)
            {
                case Models.TemperatureType.Celsius:
                    return ConvertToCelsius(request);

                case Models.TemperatureType.Fahrenheit:
                    return ConvertToFarenheight(request);
            }

            throw new Exception("Invalid type to convert");
        }

        private TemperatureConvertResponse ConvertToCelsius(TemperatureConvertRequest request)
        {
            var kelvin = request.TemperatureValueFrom ?? -1;
            var celsius = kelvin - (decimal) 273.15;

            return new TemperatureConvertResponse()
            {
                TemperatureValueFrom = kelvin,
                TemperatureValueTo = celsius
            };
        }

        private TemperatureConvertResponse ConvertToFarenheight(TemperatureConvertRequest request)
        {
            var kelvin = request.TemperatureValueFrom ?? -1;
            var fahrenheit = 1.8M * (kelvin - 273M) + 32M;

            return new TemperatureConvertResponse()
            {
                TemperatureValueFrom = kelvin,
                TemperatureValueTo = fahrenheit
            };
        }
    }
}

