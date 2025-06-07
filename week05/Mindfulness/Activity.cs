using System;

public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
    _duration = 30;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
  }

  public void setDuration(int duration)
  {
    _duration = duration;
  }

  public int getDuration()
  {
    return _duration;
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine($"Well done!!");
    ShowSpinner(3);

    Console.WriteLine();

    Console.WriteLine($"You have completed another {_duration} of {_name}.");
    ShowSpinner(3);
  }

  public void ShowSpinner(int seconds)
  {
    string[] animationStrings = ["|", "/", "-", "\\", "|", "/", "-", "\\", "|"];

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int index = 0;

    while (DateTime.Now < endTime)
    {
      Console.Write(animationStrings[index]);
      Thread.Sleep(1000);
      Console.Write("\b \b");

      index++;

      if (index >= animationStrings.Length)
      {
        index = 0;
      }
    }
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}