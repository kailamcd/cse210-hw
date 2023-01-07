using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        float grade = float.Parse(userGrade);

        string letter = "";

        if (grade > 89.9)
        {
            letter = "A";
        }
        
        else if (grade > 79.9 && grade < 90)
        {
            letter = "B";
        }
        else if (grade > 69.9 && grade < 80)
        {
            letter = "C";
        }

        else if (grade > 59.9 && grade < 70)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        string symbol = "";
        
        if (grade < 90 && grade > 59.9)
        {
            if (grade % 10 >= 7)
            {
                symbol = "+";
            }
            else if (grade % 10 <= 3)
            {
                symbol = "-";
            }
            else
            {
                symbol = "";
            }
        }
        Console.WriteLine($"Your current letter grade: {letter}{symbol}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you're passing this class!");
        }
        else
        {
            Console.WriteLine("Keep working to pull that grade up to pass this class!");
        }
    }
}