using System;

public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity(
    string name,
    string description
    ) : base(name, description)
  {
    _prompts = new List<string>();
    _questions = new List<string>();

    // Add prompts on instantiation
    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    // Add questions on instantiation
    _questions.Add("Why was this experience meaningful to you?");
    _questions.Add("Have you ever done anything like this before?");
    _questions.Add("How did you get started?");
    _questions.Add("How did you feel when it was complete?");
    _questions.Add("What made this time different than other times when you were not as successful?");
    _questions.Add("What is your favorite thing about this experience?");
    _questions.Add("What could you learn from this experience that applies to other situations?");
    _questions.Add("What did you learn about yourself through this experience?");
    _questions.Add("How can you keep this experience in mind in the future?");
  }

  public void Run()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.getDuration());

    int seconds = 5;

    while (DateTime.Now < endTime)
    {
      DisplayQuestions();
      base.ShowSpinner(seconds);
      Thread.Sleep(5);

      Console.WriteLine();
    }
  }

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int rand = random.Next(0, _prompts.Count);

    string prompt = _prompts[rand];

    return prompt;
  }

  public string GetRandomQuestion()
  {
    Random random = new Random();
    int rand = random.Next(0, _questions.Count);

    string question = _questions[rand];

    return question;
  }

  public void DisplayPrompt()
  {
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
  }

  public void DisplayQuestions()
  {
    Console.Write(GetRandomQuestion() + " ");
  }
}