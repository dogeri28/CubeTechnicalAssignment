using System;
using TC.DTOModels;

namespace TC.BusinessLogic.Abstract
{
    public interface IConvertCelsius
    {
        TemperatureConvertResponse Convert(TemperatureConvertRequest request);
    }
}

