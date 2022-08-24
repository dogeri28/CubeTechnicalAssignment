using System;
using System.Collections.Generic;
using Moq;
using TC.BusinessLogic.Abstract;
using TC.BusinessLogic.Concrete;
using TC.DTOModels;

namespace TC.BusinessLogic.UnitTests.BusinessLogicTests
{
    [TestFixture]
    public class CelsiusConverterTests : BaseTest
    {
        
        [Test]
        public void Test_CelsiusConverter_Converts_To_Fahrenheit_Correctly()
        {
            // Arrange

            var request = new TemperatureConvertRequest()
            {
                TemperatureTypeFrom = Models.TemperatureType.Celsius,
                TemperatureTypeTo = Models.TemperatureType.Fahrenheit,
                TemperatureValueFrom = 20.0M,
                TemperatureValueTo = 0
            };

            CelsiusConverter converter = new CelsiusConverter();
          
            // Act

            var conversion = converter.Convert(request);

            // Assert

            Assert.True(conversion.TemperatureValueTo == 68.0M);
        }

        [Test]
        public void Test_CelsiusConverter_Converts_To_Kelvin_Correctly()
        {
            // Arrange

            var request = new TemperatureConvertRequest()
            {
                TemperatureTypeFrom = Models.TemperatureType.Celsius,
                TemperatureTypeTo = Models.TemperatureType.Kelvin,
                TemperatureValueFrom = 10.0M,
                TemperatureValueTo = 0
            };

            CelsiusConverter converter = new CelsiusConverter();

            // Act

            var conversion = converter.Convert(request);

            // Assert

            Assert.True(conversion.TemperatureValueTo == 283.15M);
        }
    }
}