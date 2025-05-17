using System;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>();

  public string GetRandomPrompt()
  {
    // Add Prompts
    _prompts.Add("Who was the most interesting person I interacted with today?");
    _prompts.Add("What was the best part of my day?");
    _prompts.Add("How did I see the hand of the Lord in my life today?");
    _prompts.Add("what was the strongest emotion I felt today?");
    _prompts.Add("If I had one thing I could do over today, what would it be?");
    _prompts.Add("What was the best part of your day?");
    _prompts.Add("What are three things you're grateful for today?");
    _prompts.Add("Describe a moment when you felt challenged today. How did you respond?");
    _prompts.Add("What is something you're looking forward to?");
    _prompts.Add("Write about someone who made a positive impact on your life tody.");

    // Get a random prompt
    Random rand = new Random();
    int randomNumber = rand.Next(_prompts.Count);
    string randomPrompt = _prompts[randomNumber];

    return randomPrompt;
  }
}