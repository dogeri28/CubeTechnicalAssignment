using System;
using TC.DTOModels;

namespace TC.BusinessLogic.Abstract
{
    public interface IConvertFahrenheit
    {
        TemperatureConvertResponse Convert(TemperatureConvertRequest request);
    }
}

