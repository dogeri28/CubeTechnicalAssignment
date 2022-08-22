using System;
using TC.DTOModels;

namespace TC.BusinessLogic.Abstract
{
    public interface IConvertKelvin
    {
        TemperatureConvertResponse Convert(TemperatureConvertRequest request);
    }
}

