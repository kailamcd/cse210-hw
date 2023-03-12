public class Points
{
    public Points()
    {
    }

    private int _diffNum;
    private string _difficulty;
    private string _points;

    public string GetPoints(string points)
    {
        _points = points;
        return _points;
    }

    public string HowManyPoints()
    {
        Console.WriteLine("How hard will this goal be to accomplish?\nType 'e' for easy, 'm' for moderate, 'd' for difficult, or 'x' for extremely difficult.");
        _difficulty = Console.ReadLine();
        return _difficulty;
    }


}