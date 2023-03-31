public class Reception : Event
{
    private string _email;
    
    public Reception(Address address, string eventType, string title, string description, string date, string time, string email) : base(address, eventType, title, description, date, time)
    {
        _email = email;
    }

    public string ReceptionDetails()
    {
        Console.WriteLine(base.StandardDetails());
        string reception = $"Please send RSVP to: {_email}";
        return reception;
    }
}