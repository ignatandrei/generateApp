using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElasticSearchTestLog4Net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger _nlog;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ILoggerFactory loggerFactory)
        {
            _nlog = loggerFactory.CreateLogger<WeatherForecastController>();
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            IEnumerable<WeatherForecast> oRet = new List<WeatherForecast>().AsEnumerable();

            try
            {
                var rng = new Random();
                oRet = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();

                _nlog.LogDebug("Debug Information");
                _nlog.LogInformation("Some Information");
                _nlog.LogWarning("Some Information");
                _nlog.LogTrace("Some Information");

                _nlog.LogDebug(oRet.ToString());
                _nlog.LogInformation(oRet.ToString());
                _nlog.LogWarning(oRet.ToString());
                _nlog.LogTrace(oRet.ToString());
            }
            catch (Exception ex)
            {
                _nlog.LogError(ex, "my custom message");
            }

            return oRet;
        }
    }
}
