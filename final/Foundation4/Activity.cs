public abstract class Activity
{
    private string _date;
    protected int _minutes;
    private string _activityType;

    public Activity(string activityType, string date, int minutes)
    {
        _activityType = activityType;
        _date = date;
        _minutes = minutes;
    }

    public abstract decimal Distance();

    public decimal GetPace(decimal speed)
    {
        decimal pace = 60 / speed;
        return pace;
    }

    public decimal GetSpeed(decimal distance)
    {
        decimal speed = (distance / _minutes) * 60;
        return speed;
    }

    public void GetSummary(decimal distance)
    {
        Console.WriteLine($"{_date} {_activityType} ({_minutes} min) - Distance: {Distance().ToString("0.0")}, Speed: {GetSpeed(distance).ToString("0.0")} mph, Pace: {GetPace(GetSpeed(distance)).ToString("0.0")} min per mile");
    }
}