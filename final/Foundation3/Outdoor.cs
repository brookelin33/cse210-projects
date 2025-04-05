public class Outdoor : Event
{
    public string WeatherForecast { get; private set; }

    public Outdoor(string title, string description, DateTime date, string time, Address location, string weatherForecast) : base(title, description, date, time, location)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor\nWeather: {WeatherForecast}";
    }
}