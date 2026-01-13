using System;

class Program
{
    static void Main(string[] args)
    {   
        // 1st Random Number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        // Console.WriteLine(number);

        int guesses = 0;
        string game = "yes";
        while (game == "yes")
        {   
            //  prompt the user for Magic Number, convert it to int, and store it.
            Console.Write("What is the magic number? ");
            string numberFromUser = Console.ReadLine();
            int valueFromUser = int.Parse(numberFromUser);  

            if(valueFromUser == number)
            {
                Console.WriteLine("You guessed it!");
                game = "No";
                guesses = guesses + 1;
                Console.WriteLine($"You made {guesses} guesses");
                Console.WriteLine("Thank your for playing");
                Console.WriteLine("Do you want to play again? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    game = "yes";
                    // Restore Guesses to 0 if answer is yes
                    guesses = 0;
                    //  Generate a second Magic number otherwise the number will be the same as above.
                    number = randomGenerator.Next(1,100);
                    // Console.WriteLine(number);
                }
                else if (answer.ToLower() == "no")
                {
                    game = "no";
                    Console.WriteLine("Thank your for playing");
                }
                else
                {
                    Console.WriteLine("Please, enter a valid response");
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    string secondAnswer = Console.ReadLine();
                    if (secondAnswer.ToLower() == "yes")
                    {
                        game = "yes";
                        // Restore Guesses to 0 if answer is yes
                        guesses = 0;
                        //  Generate a second Magic number otherwise the number will be the same as above.
                        number = randomGenerator.Next(1,100);
                        // Console.WriteLine(number);
                    }
                    else if (secondAnswer.ToLower() == "no")
                    {
                        game = "no";
                        Console.WriteLine("Thank your for playing");
                    }
                }
            }
            else if( valueFromUser > number)
            {
                Console.WriteLine("Lower");
                guesses = guesses + 1;
            }
            else
            {
                Console.WriteLine("Higher");
                guesses = guesses + 1;
            }



        }
         
    }
}