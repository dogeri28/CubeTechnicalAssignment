using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using TC.DatabaseContext;
using TC.DTOModels;
using TC.Models;
using TC.Repository.Abstract;
using TC.Repository.Concrete;

namespace TC.Repository.UnitTests;

public class RepositoryTests
{
    private Mock<ITemperatureConverterDbContext> _mockDbContext;
    private Mock<ITemperatureConversionRepository> _mockRepository;
    private Mock<DbSet<TemperatureConversion>> _mockTemperatureConversions;

    [SetUp]
    public void Setup()
    {
        _mockDbContext = new Mock<ITemperatureConverterDbContext>();
        _mockRepository = new Mock<ITemperatureConversionRepository>();
        _mockTemperatureConversions = new Mock<DbSet<TemperatureConversion>>();
        _mockDbContext
            .Setup(x => x.TemperatureConversions)
            .Returns(_mockTemperatureConversions.Object);
    }

    [Test]
    public async Task Test_SaveTemperatureConversionMethod_Correctly_Saves_Values_To_Database()
    {
        // Arrange

        var entity = new TemperatureConvertResponse()
        {
            TemperatureTypeFrom = (int) TemperatureType.Celsius,
            TemperatureTypeTo = (int)TemperatureType.Fahrenheit,
            TemperatureValueFrom = 24.0M,
            TemperatureValueTo = 75.2M
        };

        var sut = new TemperatureConversionRepository(_mockDbContext.Object);

        // Act

         await sut.SaveTemperatureConversion(entity);

        // Assert

        _mockDbContext.Verify(x => x.TemperatureConversions.Add(
                       It.Is<TemperatureConversion>
                       (arg => arg.TemperatureTypeFrom == (TemperatureType) entity.TemperatureTypeFrom &&
                               arg.TemperatureTypeTo == (TemperatureType)entity.TemperatureTypeTo &&
                               arg.TemperatureValueFrom == entity.TemperatureValueFrom &&
                               arg.TemperatureValueTo == entity.TemperatureValueTo)));
    }
}
