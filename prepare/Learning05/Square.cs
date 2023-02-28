public class Square : Shape
{
    private double _length;

    public Square(string name, string color, double length) : base(name, color)
    {
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }

    // public void SetLength(length)
    // {
    //     _length = length;
    // }

    public override double GetArea()
    {
        return _length * _length;
    }


}