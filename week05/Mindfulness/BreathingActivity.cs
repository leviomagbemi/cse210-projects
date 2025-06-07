using System;

public class BreathingActivity : Activity
{
  public BreathingActivity(
    string name,
    string description) : base(name, description)
  {

  }

  public void Run()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.getDuration());

    int seconds = 5;

    while (DateTime.Now < endTime)
    {
      Console.Write($"Breath in...");
      base.ShowCountDown(seconds);
      Thread.Sleep(seconds);

      // Push breath out to the next line
      Console.WriteLine();
      
      Console.Write($"Now breath out...");
      base.ShowCountDown(seconds);
      Thread.Sleep(seconds);

      // Give a space before the next breath in breath out
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}