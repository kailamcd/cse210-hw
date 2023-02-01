public class Fraction
{
    private int _top;
    private int _bottom;



    // with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // in only one parameter is provided
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // if two parameters are provided
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // return fraction as a string
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    // calculate decimal value of a fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}