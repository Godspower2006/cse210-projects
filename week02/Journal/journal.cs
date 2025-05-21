using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Adds an entry to the internal list
    public void AddEntry(Entry entry) => _entries.Add(entry);

    // Displays all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var entry in _entries)
            entry.Display();
    }

    // Saves entries to file (delimiter '|' with escaping)
    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            string safePrompt = entry.Prompt.Replace("|", "\\|");
            string safeResponse = entry.Response.Replace("|", "\\|");
            writer.WriteLine($"{entry.Date}|{safePrompt}|{safeResponse}");
        }
        Console.WriteLine($"Journal saved to '{filename}'");
    }

    // Loads entries from file, reconstructing Entry objects
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' not found.");
            return;
        }
        _entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length >= 3)
            {
                var date = parts[0];
                var prompt = parts[1].Replace("\\|", "|");
                var response = parts[2].Replace("\\|", "|");
                _entries.Add(new Entry(prompt, response, date));
            }
        }
        Console.WriteLine($"Journal loaded from '{filename}'");
    }
}
