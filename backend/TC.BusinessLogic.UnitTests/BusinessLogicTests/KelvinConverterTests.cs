using System;
using TC.BusinessLogic.Concrete;
using TC.DTOModels;

namespace TC.BusinessLogic.UnitTests.BusinessLogicTests
{
    public class KelvinConverterTests : BaseTest
    {
        [Test]
        public void Test_KelvinConverter_Converts_To_Celsius_Correctly()
        {
            // Arrange

            var request = new TemperatureConvertRequest()
            {
                TemperatureTypeFrom = Models.TemperatureType.Kelvin,
                TemperatureTypeTo = Models.TemperatureType.Celsius,
                TemperatureValueFrom = 20.0M,
                TemperatureValueTo = 0
            };

            KelvinConverter converter = new KelvinConverter();

            // Act

            var conversion = converter.Convert(request);

            // Assert

            Assert.True(conversion.TemperatureValueTo == -253.15M);
        }

        [Test]
        public void Test_KelvinConverter_Converts_To_Fahrenheit_Correctly()
        {
            // Arrange

            var request = new TemperatureConvertRequest()
            {
                TemperatureTypeFrom = Models.TemperatureType.Kelvin,
                TemperatureTypeTo = Models.TemperatureType.Fahrenheit,
                TemperatureValueFrom = 10.0M,
                TemperatureValueTo = 0
            };

            KelvinConverter converter = new KelvinConverter();

            // Act

            var conversion = converter.Convert(request);

            // Assert

            Assert.True((int)conversion.TemperatureValueTo == -441);
        }
    }
}

