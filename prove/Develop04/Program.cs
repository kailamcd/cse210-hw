

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Choose a Mindfulness Activity to Begin.");
        Console.WriteLine();
        Menu menu = new Menu("Breathing Activity", "Reflection Activity", "Listing Activity");
        menu.DisplayMenu();
        Console.WriteLine("Type 1, 2, or 3 to begin an activity. Or type 'quit' to end the program.");
        string userChoice = Console.ReadLine();
        while (userChoice != "quit") {
            
            if (userChoice == "1")
            {   
                string activityName = "Breathing Activity";
//                 Console.WriteLine($"How long do you want to do the {activityName} (in seconds)?");
//                 string timeInput = Console.ReadLine();
//                 Activity activity = new Activity(timeInput);
//                 activity.GetIntTime(timeInput);
//                 BreathingActivity breathe = new BreathingActivity("This activity will help you control your breathing. Controlling your breath can calm anxiety, help you think more clearly, and increase your access to the Spirit.\nPress enter when you're ready to start.");


            }
        }
    }
}