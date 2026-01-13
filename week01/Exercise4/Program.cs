using System;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int valueFromUser = -1;
        while (valueFromUser != 0 )
        {
            Console.Write("Enter a number, type 0 to quit ");
            string userAnswer = Console.ReadLine();
            valueFromUser = int.Parse(userAnswer);

            //  Adding number to the list except 0
            if (valueFromUser != 0)
            {
                numbers.Add(valueFromUser);
            }
        }

            // Compute the sum of number in the list
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Compute the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the largest number in the list
            int largestNumber = numbers[0];
            foreach ( int number in numbers)
            {
                if (number > largestNumber )
                {
                    largestNumber = number;
                }
            }

            // Find the smallest positive number
            int smallest = numbers[0];
            foreach (int number in numbers)
        {
            if ( number > 0 && number < numbers[0])
            {
                smallest = number;
            }
        }   
            Console.WriteLine($"The smallest positive number is: {smallest}");   

            Console.WriteLine($"The largest Number: {largestNumber}");

            //  Sort the list
            numbers.Sort(); // In-place sort using default comparer

            Console.WriteLine("The sorted list is: " + string.Join(", ", numbers));
        
    }
}