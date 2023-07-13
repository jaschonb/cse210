public abstract class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Writes the standard details to the console
    public void WriteStandardDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.GetAddressString());
    }

    public abstract void WriteFullDetails();

    // Writes a short description of the event
    public void WriteShortDescription()
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_title);
        Console.WriteLine(_date);
    }
}