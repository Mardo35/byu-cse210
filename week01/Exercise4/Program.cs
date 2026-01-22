using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int valueFromUser = -1;
        
        Console.WriteLine("Enter numbers (type 0 to finish):");
        
        while (valueFromUser != 0)
        {
            Console.Write("Enter a number: ");
            string userAnswer = Console.ReadLine();
            
            // Input validation
            if (!int.TryParse(userAnswer, out valueFromUser))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }
            
            // Adding number to the list except 0
            if (valueFromUser != 0)
            {
                numbers.Add(valueFromUser);
            }
        }
        
        // Check if list is empty
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }
        
        // Compute the sum of numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        // Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average:F2}"); // Format to 2 decimal places
        
        // Find the largest number in the list
        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
        
        // Find the smallest positive number
        int? smallestPositive = null; // Use nullable int
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive.Value)
                {
                    smallestPositive = number;
                }
            }
        }
        
        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        
        // Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is: " + string.Join(", ", numbers));
    }
}

// NB,I had to research a lot to write this code, I experience an issue when I run the code with the play button
// therefore, I run the code with " Run project associated with this file"
// because the play button would run some sort of build test on the entire repository and find bug even in the week 07 files