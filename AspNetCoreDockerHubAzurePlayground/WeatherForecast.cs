namespace AspNetCoreDockerHubAzurePlayground;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public object Info => new
    {
        AppName = nameof(AspNetCoreDockerHubAzurePlayground),
        Version = "0.0.0.1",
        Contributor = "TeoVincent"
    };

    public string Test => "Test";

    public string CiCd => "CI/CD";

    public string WebHook => "WebHook";
}