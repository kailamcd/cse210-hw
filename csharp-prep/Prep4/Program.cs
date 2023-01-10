using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int largest = 0;
        int number = 1;
        List<int> numbers = new List<int>();
        do{
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        int listLength = numbers.Count;
        int sum = numbers.Sum();
        double average = numbers.Average();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}