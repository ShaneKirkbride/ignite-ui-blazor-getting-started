namespace ignite_ui_blazor_getting_started.Data
{
    /// <summary>
    /// Default implementation of <see cref="IWeatherForecastService"/>.
    /// Generates sample forecast data.
    /// </summary>
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <inheritdoc />
        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            // Generates five days of random weather data starting from the provided date
            var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();

            return Task.FromResult(forecasts);
        }
    }
}
