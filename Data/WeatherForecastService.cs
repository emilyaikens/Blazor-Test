namespace BlazorApp.Data;

public class TeapotService
{
    private static readonly string[] Colors = new[]
    {
        "Light Blue", "Candy Red", "Dusk Grey", "Sunflower Yellow", "Burnt Orange"
    };

    public Task<TeapotDate[]> GetForecastAsync(DateTime startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new TeapotDate
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Colors = Colors[Random.Shared.Next(Colors.Length)]
        }).ToArray());
    }
}
