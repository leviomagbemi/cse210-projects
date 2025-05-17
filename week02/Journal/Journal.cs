using System;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddNewEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
      Console.WriteLine($"{entry._entryText}");
      Console.WriteLine();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}~");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
      string[] parts = line.Split("~");

      foreach (string part in parts)
      {
        Console.WriteLine(part);
      } 
    }  
  }
}