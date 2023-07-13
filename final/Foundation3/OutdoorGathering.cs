public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventType, string title, string description, string date, string time, Address address, string weather)
    : base(eventType, title, description, date, time, address)
    {
        _weather = weather;
    }

    // Writes the full details of the event
    public override void WriteFullDetails()
    {
        WriteStandardDetails();
        Console.WriteLine($"Weather Forcast: {_weather}");
    }

}