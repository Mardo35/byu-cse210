using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
        
    }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName( )
        {
            Console.WriteLine("Please enter your name:");
            string  userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number);


            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
             Console.WriteLine($"{name}, the square of your number is {square}");

        }

}