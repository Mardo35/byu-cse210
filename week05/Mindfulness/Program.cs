using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        
        // Variables to track activity frequency enhancement 
        // Keeping a log of how many times activities were performed.
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++; 
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++; 
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++; 
            }
            else if (choice == "4")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-4.");
                System.Threading.Thread.Sleep(2000);
            }
        }

        // Display the log when the user hits quit
        DisplaySummary(breathingCount, reflectingCount, listingCount);
    }

    static void DisplaySummary(int breating, int reflection, int listing)
    {
        Console.Clear();
        Console.WriteLine("--- Mindfulness Log Summary ---");
        Console.WriteLine($"Breathing Sessions:  {breating}");
        Console.WriteLine($"Reflecting Sessions: {reflection}");
        Console.WriteLine($"Listing Sessions:    {listing}");
        Console.WriteLine($"Total Sessions:      {breating + reflection + listing}");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Great job taking time for yourself today. Goodbye!");
        System.Threading.Thread.Sleep(3000);
    }
}