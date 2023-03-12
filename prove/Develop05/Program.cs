using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string noExtension;
        Console.Clear();

        Menu menu = new Menu("Create New Goal", "Record Event", "Load File", "Save File", "Show Goals");
        string mainMenuChoice;
        string goalChoice;
        
        do
        {
            menu.DisplayMainMenu();
            Console.WriteLine();
            mainMenuChoice = Console.ReadLine();

            switch (mainMenuChoice)
            {

                case "1":
                    do
                    {

                        Menu goalMenu = new Menu("Simple Goal", "Eternal Goal", "Checklist Goal");
                        goalMenu.DisplayGoalMenu();
                        goalChoice = Console.ReadLine();
                        Console.Clear();

                        switch (goalChoice)
                        {
                            case "1":
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.ReceiveNewGoal();
                            simpleGoal.DisplayGoalList();
                            Console.ReadKey(true);
                            break;
                        
                            case "2":
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.ReceiveNewGoal();
                            eternalGoal.DisplayGoalList();
                            Console.ReadKey(true);
                            break;
                        
                            case "3":
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.ReceiveNewGoal();
                            checklistGoal.DisplayGoalList();
                            Console.ReadKey(true);
                            break;
                        }
                    }
                    while (goalChoice != "4");
                    break;

                case "2":
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Which goal file would you like to load? Type the file name with no extension. ");
                    noExtension = Console.ReadLine();
                    AccessFile l = new AccessFile();
                    string fileName = l.GetFileName(noExtension);
                    if (File.Exists(fileName))
                    {
                        l.Load();
                    }
                    else 
                    {
                        Console.WriteLine($"Could not find {fileName}. Please check your spelling and try again.");
                    }
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Where should your goals be saved? Type a file name with no extension. ");
                    noExtension = Console.ReadLine();
                    AccessFile file = new AccessFile();
                    fileName = file.GetFileName(noExtension);
                    if (File.Exists($"{fileName}"))
                    {
                        Console.WriteLine("File exists.");
                        file.Save(Goal._goals);
                        Console.WriteLine($"Entries have been added to {fileName}.");
                    }
                    else
                    {
                        file.CreateFile(fileName);
                        file.Save(Goal._goals);
                    }
                    break;

                case "5":
                    break;

                case "6":
                    break;

            }
         
        }

        while (mainMenuChoice != "6");
    }
        
}
