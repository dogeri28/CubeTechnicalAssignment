using System;
using Moq;
using TC.BusinessLogic.Abstract;
using TC.Repository.Abstract;

namespace TC.BusinessLogic.UnitTests.BusinessLogicTests
{
    public class BaseTest
    {
        public Mock<IConvertCelsius> _mockCelsiusConverter;
        public Mock<IConvertFahrenheit> _mockFahrenheitConverter;
        public Mock<IConvertKelvin> _mockKelvinConverter;
        public Mock<ITemperatureConversionRepository> _mockTemperatureConversionRepository;
        public Mock<ITemperatureConvertService> _mockTemperatureConvertService;

        [SetUp]
        public void Setup()
        {
            _mockTemperatureConvertService = new Mock<ITemperatureConvertService>();
            _mockCelsiusConverter = new Mock<IConvertCelsius>();
            _mockFahrenheitConverter = new Mock<IConvertFahrenheit>();
            _mockKelvinConverter = new Mock<IConvertKelvin>();
            _mockTemperatureConversionRepository = new Mock<ITemperatureConversionRepository>();
        }
    }
}

