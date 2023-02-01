using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneFifth = new Fraction(1 , 5);
        Console.WriteLine(oneFifth.GetFractionString());
        Console.WriteLine(oneFifth.GetDecimalValue());
        Console.WriteLine();
        // expected output:
        // 1/5
        // .2

        Fraction two = new Fraction(2);
        Console.WriteLine(two.GetFractionString());
        Console.WriteLine(two.GetDecimalValue());
        Console.WriteLine();
        // expected output:
        // 2/1
        // 2

        Fraction fourSixteenths = new Fraction(4 , 16);
        Console.WriteLine(fourSixteenths.GetFractionString());
        Console.WriteLine(fourSixteenths.GetDecimalValue());
        Console.WriteLine();
        // expected output:
        // 4/16
        // .25

        Fraction oneOne = new Fraction();
        Console.WriteLine(oneOne.GetFractionString());
        Console.WriteLine(oneOne.GetDecimalValue());
        Console.WriteLine();
        // expected output:
        // 1/1
        // 1
    }
}