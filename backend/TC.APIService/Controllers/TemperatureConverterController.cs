using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TC.BusinessLogic.Abstract;
using TC.DTOModels;

namespace TemperatureConverterApp.Controllers
{
    [ApiController]
    [Route("api/temperature")]
    public class TemperatureController : ControllerBase
    {
        private readonly ILogger<TemperatureController> _logger;
        private readonly ITemperatureConvertService _temperatureConvertService;

        public TemperatureController(ILogger<TemperatureController> logger,
                                              ITemperatureConvertService temperatureConvertService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _temperatureConvertService = temperatureConvertService ?? throw new ArgumentNullException(nameof(temperatureConvertService));
        }

        /// <summary>
        /// This api endpoint converts temperatures between Celsius,
        /// Fahrenheit and Kelvin metrics.
        /// </summary>
        /// <remarks>
        /// The **temperatureTypeFrom** and **temperatureTypeTo**
        /// numerical values are mapped as follows
        ///  * 1 - Celsius
        ///  * 2 - Fahrenheit 
        ///  * 3 - Kelvin
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<TemperatureConvertResponse> ConvertTemperature([FromBody] TemperatureConvertRequest request)
        {
           var response = await _temperatureConvertService.HandleTemperatureConversion(request);
            return response;
        }
    }
}