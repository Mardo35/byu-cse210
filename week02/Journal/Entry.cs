using System;

namespace journal
{
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;
        // enhancement, quote provided when user enters entry.
        public string _quote;

        // Constructor for new entries
        public Entry(string promptText, string entryText, string quote)
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _promptText = promptText;
            _entryText = entryText;
            _quote = quote;
        }

        // Constructor for loading from file
        public Entry(string promptText, string entryText, string date, string quote)
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
            _quote = quote;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
            
            // Display quote if it exists
            if (!string.IsNullOrWhiteSpace(_quote))
            {
                Console.WriteLine($"Quote: {_quote}");
            }
            
            Console.WriteLine();
        }
    }
}