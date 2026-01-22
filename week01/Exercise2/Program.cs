using System;

class Program
{
    static void Main(string[] args)
    {
        // Grades
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F <  60

        Console.Write("Please, enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();

        // Input validation
        if (!int.TryParse(valueFromUser, out int grade))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        // Ensure grade is within valid range (0-100)
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Grade must be between 0 and 100.");
            return;
        }

        // Variable Letter to hold the grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // Display grade first
        Console.WriteLine($"Your grade is: {letter}");

        // Then pass/fail message
        if (grade >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("You will get it next time. Keep trying!");
        }
    }
}