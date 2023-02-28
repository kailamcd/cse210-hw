public class Rectangle : Shape
{
    private double _length;
    private double _height;

    public Rectangle(string name, string color, double length, double height) : base(name, color)
    {
        _length = length;
        _height = height;
    }

    public double GetLength()
    {
        return _length;
    }

    public double GetHeight()
    {
        return _height;
    }

    // public void SetLength(length)
    // {
    //     _length = length;
    // }

    // public void SetHeight(height)
    // {
    //     _height = height;
    // }

    public override double GetArea()
    {
        return _length * _height;
    }
}