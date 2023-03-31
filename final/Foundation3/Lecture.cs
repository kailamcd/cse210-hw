public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(Address address, string eventType, string title, string description, string date, string time, string speaker, int capacity) : base(address, eventType, title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string LectureDetails()
    {
        Console.WriteLine(base.StandardDetails());
        string lecture = $"Speaker: {_speaker}\nEvent Capacity: {_capacity.ToString()} seats";
        return lecture;
    }


}