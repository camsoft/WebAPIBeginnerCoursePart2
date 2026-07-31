namespace WebAPICourse
{
    /// <summary>
    /// This is the model class for the WeatherForecast API. It represents the weather forecast data for a specific date, including temperature in Celsius and Fahrenheit, and a summary description.
    /// This is an example of a simple data model used in a Web API application. In a real-world application, you would typically retrieve this data from a database or an external API.
    /// Model data should never be hardcoded in the controller, it should be retrieved from a service class or a repository class. This is just for demonstration purposes.
    /// </summary>
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
