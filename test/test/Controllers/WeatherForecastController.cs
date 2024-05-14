using Microsoft.AspNetCore.Mvc;
using test.configs;
using test.Models;
namespace test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private config config = new config();
        public List<Forum> configs;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Forum> Get()
        {
            return this.config.LoadConfig(); 
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public void Post([FromBody] Forum forum)
        {

            this.config.add(forum);
            this.config.SaveConfig();
        }

        [HttpPut(Name = "PutWeatherForecast")]
        public void Put([FromBody] Forum forum)
        {
  
            forum.comments = null;
            this.config.edit(forum);
            this.config.SaveConfig();
        }

        [HttpDelete("{id}", Name = "DeleteWeatherForecast")]
        public void Delete(int id)
        {
            this.config.delete(id);
            this.config.SaveConfig();
        }
    }
}
