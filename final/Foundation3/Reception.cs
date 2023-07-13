public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventType, string title, string description, string date, string time, Address address, string email)
    : base(eventType, title, description, date, time, address)
    {
        _rsvpEmail = email;
    }

    // Writes the full details of the event
    public override void WriteFullDetails()
    {
        WriteStandardDetails();
        Console.WriteLine($"RSVP to: {_rsvpEmail}");
    }
}