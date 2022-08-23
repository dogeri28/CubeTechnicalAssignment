using System;
using TC.DTOModels;

namespace TC.BusinessLogic.Abstract
{
    public interface ITemperatureConvertService
    {
       Task<TemperatureConvertResponse> HandleTemperatureConversion(TemperatureConvertRequest request);
    }
}

