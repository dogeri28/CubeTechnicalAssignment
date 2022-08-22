using System;
using TC.DTOModels;

namespace TC.BusinessLogic.Abstract
{
    public interface ITemperatureConvertService
    {
        TemperatureConvertResponse HandleTemperatureConversion(TemperatureConvertRequest request);
    }
}

