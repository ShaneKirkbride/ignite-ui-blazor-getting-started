namespace ignite_ui_blazor_getting_started.Data
{
    /// <summary>
    /// Abstraction for the weather forecast provider.
    /// </summary>
    public interface IWeatherForecastService
    {
        /// <summary>
        /// Returns forecast information for five days starting from the supplied date.
        /// </summary>
        /// <param name="startDate">The date from which forecasting begins.</param>
        /// <returns>An array of <see cref="WeatherForecast"/> values.</returns>
        Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate);
    }
}
