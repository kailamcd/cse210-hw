// Your program must do the following:

// Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
// Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
// Clear the console screen and display the complete scripture, including the reference and the text.
// Prompt the user to press the enter key or type quit.
// If the user types quit, the program should end.
// If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
// The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
// When all words in the scripture are hidden, the program should end.
// When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)

using System;

class Program
{
    static void Main(string[] args)
    {



            Console.Clear();
            Console.WriteLine("Welcome to Scripture Memorizer!");
            Console.WriteLine();
            Console.WriteLine("There is a preloaded scripture available to memorize (Ether 12:27), but you can also enter your own scripture.");
            Console.WriteLine("Would you like to enter your own scripture to memorize? y/n ");
            string ownScripture = Console.ReadLine();

            if (ownScripture == "y") {
                Console.Clear();
                Console.WriteLine("What is the book? ");
                string book = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is the chapter? ");
                string chapter = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What are the verses (x or x-x for multiple verses)?");
                string verses = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is the text of the verses? Hit return only after all verses are typed. ");
                string text = Console.ReadLine();
                Scripture userScripture = new Scripture(new Reference(book, chapter, verses), text);

                string userChoice = "";
                while (userChoice != "quit") {
                    Console.WriteLine(userScripture.GetScriptureText());
                    int wordCount = userScripture.GetWordCount();
                    int hiddenCount = userScripture.IsCompletelyHidden(0, wordCount);

                    Console.WriteLine("\nPress enter to hide words or type 'quit' to exit program.");

                    userChoice = Console.ReadLine();
                    if (userChoice == "quit") {
                        Console.WriteLine("\nCome practice your scripture again soon!");
                        break;
                    }
                    else if (userChoice == "") {
                        userScripture.HideRandomWords();

                        if (userScripture.IsCompletelyHidden(0, wordCount) == 0) {
                            break;
                    }
                        else {
                            userScripture.HideRandomWords();
                        }
                            if (userScripture.IsCompletelyHidden(0, wordCount) == 0) {
                            break;
                            }
                            else {
                                userScripture.HideRandomWords();
                            }

                            }
                        }
                    }
            else {
                Scripture scripture = new Scripture(new Reference("Ether", "12", "27"), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

                string userChoice = "";

                while (userChoice != "quit") {
                    Console.WriteLine(scripture.GetScriptureText());
                    int wordCount = scripture.GetWordCount();
                    int hiddenCount = scripture.IsCompletelyHidden(0, wordCount);

                    Console.WriteLine("\nPress enter to hide words or type 'quit' to exit program.");

                    userChoice = Console.ReadLine();
                    if (userChoice == "quit") {
                        Console.WriteLine("\nCome practice your scripture again soon!");
                        break;
                    }
                    else if (userChoice == "") {
                        scripture.HideRandomWords();

                        if (scripture.IsCompletelyHidden(0, wordCount) == 0) {
                            break;
                        }
                        else {
                            scripture.HideRandomWords();
                        }

                            if (scripture.IsCompletelyHidden(0, wordCount) == 0) {
                                break;
                            }
                            else {
                                scripture.HideRandomWords();
                            }

                    }
                }
            }
}

}