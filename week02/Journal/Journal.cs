using System;
using System.Security;

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
      entry.Display();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    // Read Each Entries Into a line
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    { 
      // Get Entry Parts: _date, _promptText, _entryText
      string[] parts = line.Split("~");

      Entry newEntry = new Entry();

      newEntry._date = parts[0];
      newEntry._promptText = parts[1];
      newEntry._entryText = parts[2];

      AddNewEntry(newEntry);
    }  
  }
}