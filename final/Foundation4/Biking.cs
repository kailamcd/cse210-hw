public class Biking : Activity
{
    private int _speed;
    private decimal _time;

    public Biking(string activityType, string date, int minutes, int speed, decimal time) : base(activityType, date, minutes)
    {
        _speed = speed;
        _time = time;
    }

    public override decimal Distance()
    {
        decimal distance = (_speed * _time) / 60;
        return distance;
    }


}