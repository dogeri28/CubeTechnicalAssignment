using System;
using TC.BusinessLogic.Abstract;
using TC.DatabaseContext;
using TC.DTOModels;
using TC.Models;
using TC.Repository.Abstract;

namespace TC.BusinessLogic.Concrete
{
    public class TemperatureConvertService :   ITemperatureConvertService
    {
        #region Dependency Injected fields

        private readonly IConvertCelsius _celsiusConverter;
        private readonly IConvertFahrenheit _fahrenheitConverter;
        private readonly IConvertKelvin _kelvinConverter;
        private readonly ITemperatureConversionRepository _temperatureConversionRepository;

        #endregion

        public TemperatureConvertService(IConvertCelsius celsiusConverter,
                                         IConvertFahrenheit fahrenheitConverter,
                                         IConvertKelvin kelvinConverter,
                                         ITemperatureConversionRepository temperatureConversionRepository)
        {
            _celsiusConverter = celsiusConverter ?? throw new ArgumentNullException(nameof(celsiusConverter));
            _fahrenheitConverter = fahrenheitConverter ?? throw new ArgumentNullException(nameof(fahrenheitConverter));
            _kelvinConverter = kelvinConverter ?? throw new ArgumentNullException(nameof(kelvinConverter));
            _temperatureConversionRepository = temperatureConversionRepository ?? throw new ArgumentNullException(nameof(temperatureConversionRepository));
        }

        public async Task<TemperatureConvertResponse> HandleTemperatureConversion(TemperatureConvertRequest request)
        {
            TemperatureConvertResponse response; 
            switch (request.TemperatureTypeFrom)
            {
                case Models.TemperatureType.Celsius:
                 response = _celsiusConverter.Convert(request);
                    break;
                case Models.TemperatureType.Fahrenheit:
                 response = _fahrenheitConverter.Convert(request);
                    break;
                case Models.TemperatureType.Kelvin:
                  response = _kelvinConverter.Convert(request);
                    break;
                        default:
                       throw new ArgumentException("invalid temperature type supplied");
            }

          var result = await _temperatureConversionRepository.SaveTemperatureConversion(response);
          return MapResponse(result);
        }

        private TemperatureConvertResponse MapResponse(TemperatureConversion temperatureConversion)
        {
            return new TemperatureConvertResponse()
            {
                 TemperatureTypeFrom =(int) temperatureConversion.TemperatureTypeFrom,
                 TemperatureTypeTo = (int) temperatureConversion.TemperatureTypeTo,
                 TemperatureValueFrom = temperatureConversion.TemperatureValueFrom ?? -1,
                 TemperatureValueTo = temperatureConversion.TemperatureValueTo ?? -1
            };
        }
    }
}

