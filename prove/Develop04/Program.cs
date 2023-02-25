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
                    string activityName = "Breathing Activity";
                    int time = activity.GetIntTime(activityName);
                    Console.Clear();
                    Console.WriteLine(activity.GetStartMessage(activityName, time));
                    activity.Pause();
                    BreathingActivity breathe = new BreathingActivity();
                    Console.WriteLine(breathe.GetBreathDescription());
                    Console.ReadKey(true);
                    breathe.RunBreathingActivity(time);
                    break;

                case "2":
                    activityName = "Reflecting Activity";
                    time = activity.GetIntTime(activityName);
                    Console.Clear();
                    Console.WriteLine(activity.GetStartMessage(activityName, time));
                    activity.Pause();
                    ReflectingActivity reflect = new ReflectingActivity();
                    Console.WriteLine(reflect.GetReflectionDescription());
                    Console.ReadKey(true);
                    reflect.RunReflectingActivity(time);               
                    break;

                case "3":
                    activityName = "Listing Activity";
                    time = activity.GetIntTime(activityName);
                    Console.Clear();
                    Console.WriteLine(activity.GetStartMessage(activityName, time));
                    Console.WriteLine();
                    ListingActivity list = new ListingActivity();
                    Console.WriteLine(list.GetListingDescription());
                    Console.ReadKey(true);
                    list.RunListingActivity(time);
                    break;

                case "4":
                    break;

            }
         
        }

        while (userChoice != "4");
    }
}       