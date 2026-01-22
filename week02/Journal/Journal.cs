using System;
using System.Collections.Generic;
using System.IO;

namespace journal
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("You have no entries to display, consider writing some");
                return;
            }

            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    // Save ALL FOUR parts: Date, Prompt, Entry text, and Quote
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._quote}");
                }
            }
            Console.WriteLine($"Entries saved to {file}");
        }

        public void LoadFromFile(string file)
        {
            // Clear existing entries before loading new ones
            _entries.Clear();
            
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split by pipe character to get all four parts
                    var parts = line.Split('|');
                    
                    if (parts.Length >= 3)
                    {
                        string date = parts[0].Trim();
                        string prompt = parts[1].Trim();
                        string entryText = parts[2].Trim();
                        string quote = parts.Length > 3 ? parts[3].Trim() : "";
                        
                        // Use the constructor with date to preserve the loaded date
                        Entry loadedEntry = new Entry(prompt, entryText, date, quote);
                        _entries.Add(loadedEntry);
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Could not parse line: {line}");
                    }
                }
            }
            Console.WriteLine($"Loaded {_entries.Count} entries from {file}");
        }
    }
}