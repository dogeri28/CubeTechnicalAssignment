using System;
using TC.Models;

namespace TC.DTOModels
{
    public class TemperatureConvertResponse
    {
        public decimal TemperatureValueFrom { get; set; }

        public decimal TemperatureValueTo { get; set; }

        public int TemperatureTypeFrom { get; set; }

        public int TemperatureTypeTo { get; set; }
    }
}

