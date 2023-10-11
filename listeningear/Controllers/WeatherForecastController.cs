using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace listeningear.Controllers;

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
        var yourConnectionString = "Server=listening-ear.mysql.database.azure.com;User ID=mob_admin;Password=Password@1234;Database=mob_db";

        using var connection = new MySqlConnection(yourConnectionString);
        connection.Open();

        using var command = new MySqlCommand("SELECT field FROM user_test;", connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var value = reader.GetValue(0);
            // do something with 'value'
        }
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
