using System;
using journal; // Import the journal namespace

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the necessary classes
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        string assignment = "on";
        while (assignment != "off")
        {
            // Display menu
            Console.WriteLine("Welcome to the journal program");
            Console.WriteLine("Please, select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // Get user input
            string numberFromUser = Console.ReadLine()!;
            int valueFromUser;

            // Enhancement: Try to convert string to numbers. If user enters non-numeric input, the loop continues
            if (!int.TryParse(numberFromUser, out valueFromUser))
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                continue;
            }

            switch (valueFromUser)
            {
                case 1:
                    // Write: Add a new entry
                    Console.WriteLine("Please write your entry:");
                    
                    // Get the inspirational quote first, enhancement
                    string quote = promptGenerator.GetRandomQuote();
                    Console.WriteLine($"Today's inspiration: {quote}");

                    // Get the random prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");

                    // Get the user's entry
                    string entryText = Console.ReadLine() ?? "";

                    // Create a new Entry and add it to the journal
                    Entry newEntry = new Entry(prompt, entryText, quote);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Your entry has been added.");
                    break;

                case 2:
                    // Display: Show all entries
                    if (myJournal._entries.Count > 0)
                    {
                        myJournal.DisplayAll();
                    }
                    else
                    {
                        Console.WriteLine("No entries to display.");
                    }
                    break;

                case 3:
                    // Load: Load entries from a file
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine() ?? "";
                    if (!string.IsNullOrEmpty(loadFile))
                    {
                        myJournal.LoadFromFile(loadFile);
                    }
                    else
                    {
                        Console.WriteLine("Invalid filename.");
                    }
                    break;

                case 4:
                    // Save: Save entries to a file
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine() ?? "";
                    if (!string.IsNullOrEmpty(saveFile))
                    {
                        myJournal.SaveToFile(saveFile);
                    }
                    else
                    {
                        Console.WriteLine("Invalid filename.");
                    }
                    break;

                case 5:
                    // Quit: Exit the program
                    Console.WriteLine("Thank you for coming today, see you next time.");
                    assignment = "off";
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}