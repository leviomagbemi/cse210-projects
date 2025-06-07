using System;

public class ListingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _responses;

  public ListingActivity(
    string name,
    string description) : base(name, description)
  {
    _prompts = new List<string>();
    _responses = new List<string>();

    _prompts.Add("List as many things as you can that make you feel grateful.");
    _prompts.Add("List the people who have had a positive influence on your life");
    _prompts.Add("List moments in your life when you felt at peace.");
    _prompts.Add("List the strengths or talents you have that you are proud of.");
    _prompts.Add("List positive habits you want to develop.");
  }

  public void Run()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.getDuration());

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string response = Console.ReadLine();
      _responses.Add(response);
    }
  }

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int rand = random.Next(0, _prompts.Count);

    string prompt = _prompts[rand];

    return prompt;
  }

  public List<string> GetListFromUser()
  {
    return _responses;
  }
}