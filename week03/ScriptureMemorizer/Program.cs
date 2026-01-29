using System;

class Program
{
    static void Main(string[] args)
    { 
        //   Exceeding requirements

         ScriptureLibrary library = new ScriptureLibrary();
         Scripture selectedScripture = library.GetRandomScripture();

    while (true)
    {
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        
        if (selectedScripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nRemember, consistency is key.");
            Console.WriteLine("2 Nephi 25:23");
            Console.WriteLine("For we labor diligently to write, to persuade our children, and also our brethren, to believe in Christ, and to be reconciled to God; for we know that it is by grace that we are saved, after all we can do");
            break;
        }

        Console.WriteLine("\nPress enter to hide words or type 'quit':");
        string input = Console.ReadLine();

        if (input.ToLower() == "quit")

            break;

        selectedScripture.HideRandomWords(3);
    }
    }
} 