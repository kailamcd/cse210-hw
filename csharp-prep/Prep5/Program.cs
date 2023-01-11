using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int result = SquareNumber(number);
        DisplayResult(name, result);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }  
    static int SquareNumber(int number)
    {
        int result = number * number;
        return result;
    }
    static void DisplayResult(string name, int result)
    {
        Console.WriteLine($"{name}, the square of your number is {result}.");
    }
}