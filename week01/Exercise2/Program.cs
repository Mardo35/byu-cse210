using System;

partial class Program
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

        int grade = int.Parse(valueFromUser);
        // Console.Write($"Your grade is {grade}");

        // Variable Letter to hold the grade
        string letter = " ";

        if ( grade >= 90 )
        {
            // Console.WriteLine("Your grade is A");
            letter = "A";
        }
        else if ( grade >= 80)
        {
            // Console.WriteLine("Your grade is B");
            letter = "B";

        }
        else if (grade >= 70 )
        {
            // Console.WriteLine("Your grade is C");
            letter = "C";
        }
        else if ( grade >= 60)
        {
            // Console.WriteLine("Your grade is D");
            letter = "D";
        }
        else 
        {
            // Console.WriteLine("Your grade is F");
            letter = "F";
        } 
        if(grade >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else
        {
            Console.WriteLine("You will get it next time");
        }

        // Console.WriteLine($"Your grade is {letter}");

        string sign = " ";
        int remainder = grade % 10;
        // Console.WriteLine(remainder);
        if (grade >= 60 && grade < 100)
        {
            if(remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder < 3)
            {
                sign = "-";
            }
        }
        
        //  no A+, F+ or F-
        if (letter == "A" && sign == "+")
        {
            sign = " ";
        }
        if(letter == "F")
        {
            sign = " ";
        }


        //  Final test
        Console.WriteLine($"Your grade is {letter}{sign}");
    }
}