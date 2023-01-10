using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        
        do{
            int number_of_guesses = 0;
            int number = -1;
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1,11);
            Console.WriteLine($"What is the magic number? {magic_number}");

            do{
                Console.Write("What is your guess? ");
                number_of_guesses++;
                string userNum = Console.ReadLine();
                number = int.Parse(userNum);
                if (number > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else if (number < magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (number != magic_number);

            Console.WriteLine($"That took {number_of_guesses} guesses!");
            Console.Write("Do you want to play again? ");
            play = Console.ReadLine();
        } while (play == "yes");
    }
}