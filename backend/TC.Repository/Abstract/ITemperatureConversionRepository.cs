using System;
using TC.DTOModels;
using TC.Models;

namespace TC.Repository.Abstract
{
    public interface ITemperatureConversionRepository
    {
       Task<TemperatureConversion> SaveTemperatureConversion(TemperatureConvertResponse response);
    }
}

