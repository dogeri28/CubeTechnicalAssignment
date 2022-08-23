using System;
using TC.BusinessLogic.Concrete;
using TC.DTOModels;

namespace TC.BusinessLogic.UnitTests.BusinessLogicTests
{
    public class FahrenheitConverterTests : BaseTest
    {
        [Test]
        public void Test_FahrenheitConverter_Converts_To_Celsius_Correctly()
        {
            // Arrange

            var request = new TemperatureConvertRequest()
            {
                TemperatureTypeFrom = Models.TemperatureType.Fahrenheit,
                TemperatureTypeTo = Models.TemperatureType.Celsius,
                TemperatureValueFrom = 40.0M,
                TemperatureValueTo = 0
            };

            FahrenheitConverter converter = new FahrenheitConverter();

            // Act

            var conversion = converter.Convert(request);

            // Assert

            Assert.True(Math.Round(conversion.TemperatureValueTo, 2) == 4.44M);
        }

        [Test]
        public void Test_FahrenheitConverter_Converts_To_Kelvin_Correctly()
        {
            // Arrange

            var request = new TemperatureConvertRequest()
            {
                TemperatureTypeFrom = Models.TemperatureType.Fahrenheit,
                TemperatureTypeTo = Models.TemperatureType.Kelvin,
                TemperatureValueFrom = 40.0M,
                TemperatureValueTo = 0
            };

            FahrenheitConverter converter = new FahrenheitConverter();

            // Act

            var conversion = converter.Convert(request);

            // Assert

            Assert.True( (int) conversion.TemperatureValueTo == 277);
        }
    }
}

