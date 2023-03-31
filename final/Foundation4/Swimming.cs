public class Swimming : Activity
{
    private decimal _numLaps;

    public Swimming(string activityType, string date, int minutes, decimal laps) : base(activityType, date, minutes)
    {
        _numLaps = laps;
    }

    public override decimal Distance()
    {
        decimal distance = _numLaps * 50m / 1000m * .62m;
        return distance;
    }



}