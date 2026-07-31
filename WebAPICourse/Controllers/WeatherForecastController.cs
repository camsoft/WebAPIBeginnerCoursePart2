using Microsoft.AspNetCore.Mvc;

namespace WebAPICourse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            /// <summary>
            // This is a simple example of generating random weather data for demonstration purposes 
            // Note : In a real-world application, you would typically retrieve this data from a database or an external API.
            // This is an example of bad coding practice, business logic should not be in the controller, it should be in a service class. This is just for demonstration purposes.
            // </summary>

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
