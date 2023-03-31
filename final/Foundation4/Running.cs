public class Running : Activity
{
    private decimal _distance;

    public Running(string activityType, string date, int minutes, decimal distance) : base(activityType, date, minutes)
    {
        _distance = distance;
    }

    public override decimal Distance()
    {
        return _distance;
    }
}