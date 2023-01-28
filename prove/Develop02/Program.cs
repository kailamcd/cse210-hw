using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string menuSelection = "0";
        Menu(menuSelection);

    }
    
    static void Menu(string menuSelection)
    {
        Journal myJournal = new Journal();
        while (menuSelection != "5")
        {
            // display the menu
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            menuSelection = Console.ReadLine();

            // write menu option
            if (menuSelection == "1")
            {
                // generate prompt and display to user
                Prompt prompt1 = new Prompt();
                string prompt = prompt1.DisplayPrompt();
                Console.WriteLine($"{prompt}");

                // receive entry and save prompt, response, and date to class
                Entry entry1 = new Entry();
                entry1._prompt = prompt;
                entry1._entry = Console.ReadLine();
                Console.WriteLine("What is today's date? ");
                entry1._date = Console.ReadLine();
                entry1.DisplayEntryDetails();

                // add entry to Journal class
                myJournal._entries.Add(entry1);


                // add entry to Save class
                // Save save1 = new Save();
                // save1._entries.Add(entry1);
            }
            
            // display menu option
            if (menuSelection == "2")
            {
                myJournal.DisplayJournal();
            }

            if (menuSelection == "3")
            {
                Console.WriteLine("What is the name of your journal file?");
                string noExtension = Console.ReadLine();
                myJournal._fileName = ($"{noExtension}.txt");
                if (File.Exists($"{myJournal._fileName}"))
                {
                    Console.WriteLine($"{myJournal._fileName} has been loaded.");
                    myJournal.Load();
                }
                else
                {
                    Console.WriteLine("That file does not exist.");
                }
            }

            // save menu option
            if (menuSelection == "4")
            {
                Console.WriteLine("What should your journal file be named?");
                string noExtension = Console.ReadLine();
                myJournal._fileName = ($"{noExtension}.txt");
                if (File.Exists($"{myJournal._fileName}"))
                {
                    Console.WriteLine("File exists.");
                    myJournal.Save();
                    Console.WriteLine($"Entries have been added to {myJournal._fileName}.");
                }
                else
                {
                    myJournal.CreateFile();
                    if (File.Exists($"{myJournal._fileName}"))
                    {
                        Console.WriteLine("File has been created.");
                        myJournal.Save();
                        Console.WriteLine($"Entries have been added to {myJournal._fileName}.");
                    }
                }
            }
        }
    }

}

