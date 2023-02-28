public class Circle : Shape
{
    private double _radius;
    private double _pi = Math.PI;

    
    public Circle(string name, string color, double radius) : base(name, color)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    // public void SetRadius(radius)
    // {
    //     _radius = radius;
    // }

    public override double GetArea()
    {
        return _pi * (_radius * _radius); //find pi
    }
}