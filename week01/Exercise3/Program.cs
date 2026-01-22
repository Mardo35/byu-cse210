using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";
        
        while (playAgain.ToLower() == "yes")
        {
            // Generate new magic number for each game
            int magicNumber = randomGenerator.Next(1, 101); // Note: Next(1, 101) gives 1-100
            int guesses = 0;
            bool guessedCorrectly = false;
            
            Console.WriteLine("\n=== New Game ===");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            
            while (!guessedCorrectly)
            {
                // Get user's guess with validation
                int guess = 0;
                bool validInput = false;
                
                while (!validInput)
                {
                    Console.Write("What is your guess? ");
                    string input = Console.ReadLine();
                    
                    if (int.TryParse(input, out guess))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                
                guesses++;
                
                // Check guess
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {guesses} guesses!");
                    guessedCorrectly = true;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
            
            // Ask if user wants to play again
            Console.Write("\nDo you want to play again? (yes/no): ");
            playAgain = Console.ReadLine()?.Trim().ToLower();
            
            // Validate response
            while (playAgain != "yes" && playAgain != "no")
            {
                Console.Write("Please enter 'yes' or 'no': ");
                playAgain = Console.ReadLine()?.Trim().ToLower();
            }
            
            if (playAgain == "no")
            {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}