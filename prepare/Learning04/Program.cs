using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simple = new Assignment("Kaila", "Reflection");

        Console.WriteLine(simple.GetSummary());
        Console.WriteLine();

        WritingAssignment essay1 = new WritingAssignment("Kaila", "Rhetorical Analysis", "A World Split Apart");

        Console.WriteLine(essay1.GetSummary());
        Console.WriteLine(essay1.GetWritingInformation());
        Console.WriteLine();

        MathAssignment homework1 = new MathAssignment("Kaila", "Charts and Graphs", "6", "1-24");

        Console.WriteLine(homework1.GetSummary());
        Console.WriteLine(homework1.GetHomeworkList());
        Console.WriteLine();
    }
}