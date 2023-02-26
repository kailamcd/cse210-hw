using System;
using System.Threading;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Choose a Mindfulness Activity to Begin.");
        Console.WriteLine();
        Menu menu = new Menu("Breathing Activity", "Reflection Activity", "Listing Activity");
        string userChoice = "";
        
        do
        {
            menu.DisplayMenu();
            Console.WriteLine();
            Console.WriteLine("Type 1, 2, or 3 to begin an activity. Type 4 to quit.");
            userChoice = Console.ReadLine();
            Activity activity = new Activity();

            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathe = new BreathingActivity();
                    string activityName = "Breathing Activity";
                    int time = breathe.GetIntTime(activityName);
                    breathe.RunBreathingActivity(activityName, time);
                    break;

                case "2":
                    ReflectingActivity reflect = new ReflectingActivity();
                    activityName = "Reflecting Activity";
                    time = reflect.GetIntTime(activityName);
                    reflect.RunReflectingActivity(activityName, time);               
                    break;

                case "3":
                    ListingActivity list = new ListingActivity();
                    activityName = "Listing Activity";
                    time = list.GetIntTime(activityName);
                    list.RunListingActivity(activityName, time);
                    break;

                case "4":
                    break;

            }
         
        }

        while (userChoice != "4");
    }
}       