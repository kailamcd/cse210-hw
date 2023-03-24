public class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    public Event(string eventType, string title, string description, string date, string time)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public string StandardDetails()
    {
        return $"{_title}\n{_description}\n{_time}\n{_address}"
    }

    public virtual string FullDetails()
    {
        
    }


}