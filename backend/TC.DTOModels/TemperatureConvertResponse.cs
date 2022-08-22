using System;
using TC.Models;

namespace TC.DTOModels
{
    public class TemperatureConvertResponse
    {
        public decimal TemperatureValueFrom { get; set; }

        public decimal TemperatureValueTo { get; set; }

        public TemperatureType TemperatureTypeFrom { get; set; }

        public TemperatureType TemperatureTypeTo { get; set; }
    }
}

