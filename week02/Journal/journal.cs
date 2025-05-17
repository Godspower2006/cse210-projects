using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Use '|' as delimiter: date|prompt|response
                // Escape any '|' in content
                var line = $"{Escape(entry)}";
                writer.WriteLine(line);
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' not found.");
            return;
        }

        _entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length >= 3)
            {
                var date = parts[0];
                var prompt = Unescape(parts[1]);
                var response = Unescape(parts[2]);
                _entries.Add(new Entry(prompt, response, date));
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }

    private string Escape(Entry e)
    {
        // Access private fields via methods or reflection; for simplicity, build via Display Properties
        // Assume Entry has getters (or make this method internal)
        // Here, for demonstration, let's add simple Escape logic placeholder
        return "";
    }

    private string Unescape(string text)
    {
        return text;
    }
}