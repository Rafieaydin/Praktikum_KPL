using Microsoft.AspNetCore.Mvc;

namespace apiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 12).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{id}", Name = "GetWeatherForecastById")]
        public WeatherForecast Get(int id)
        {
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(id),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[1]
            };
        }

        [HttpPost(Name = "CreateWeatherForecast")]
        public ActionResult<WeatherForecast> Create(WeatherForecast weatherForecast)
        {
            return CreatedAtRoute("GetWeatherForecastById", new { id = 1 }, weatherForecast);
        }

        [HttpPut("{id}", Name = "UpdateWeatherForecast")]
        public ActionResult<WeatherForecast> Update(int id, WeatherForecast weatherForecast)
        {
            return weatherForecast;
        }

        [HttpDelete("{id}", Name = "DeleteWeatherForecast")]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
