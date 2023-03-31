public class Outdoor : Event
{
    private string _weather;

    public Outdoor(Address address, string eventType, string title, string description, string date, string time, string weather) : base(address, eventType, title, description, date, time)
    {
        _weather = weather;
    }

    public string OutdoorDetails()
    {
        Console.WriteLine(base.StandardDetails());
        string outdoor = $"The weather is predicted to be {_weather}.";
        return outdoor;
    }

}