using System;
using System.Runtime.InteropServices;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  private int _oldScore;
  private int _numberOfOldGoals;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
    _oldScore = 0;
    _numberOfOldGoals = -1;
  }

  public void Start()
  {
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Create New Goal");
    Console.WriteLine("  2. List Goals");
    Console.WriteLine("  3. Save Goals");
    Console.WriteLine("  4. Load Goals");
    Console.WriteLine("  5. Record Event");
    Console.WriteLine("  6. Quit");
    Console.Write("Select a choice from the menu: ");
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine();
    Console.WriteLine($"You have {_score} points.");
    Console.WriteLine();
  }

  public void ListGoalName()
  {
    Console.WriteLine("The types of goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("what type of goal you would like to create? ");
  }

  public void ListGoalDetails()
  {
    int index = 1;

    Console.WriteLine("The goals are:");

    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{index}. {goal.GetDetailsString()}");
      index++;
    }
  }

  public void CreateGoal()
  {
    // Choose Goal to Create From The Menu on ListGoalName
    int goalChoice = int.Parse(Console.ReadLine());

    // Ask for Informations Necessary to Create Goal
    Console.Write("What is the name of your goal? ");
    string goalName = Console.ReadLine();

    Console.Write("What is your short description of it? ");
    string goalDescription = Console.ReadLine();

    Console.Write("What is the amount of point associated with this goal? ");
    int goalPoint = int.Parse(Console.ReadLine());


    // Create Goal Based on User Choice
    switch (goalChoice)
    {
      case 1:
        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoint);

        _goals.Add(simpleGoal);
        break;

      case 2:
        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoint);

        _goals.Add(eternalGoal);
        break;

      case 3:
        // Ask Further Questions if Goal is a Checklist Goal
        Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
        int goalTarget = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int achievementBonus = int.Parse(Console.ReadLine());

        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoint, goalTarget, achievementBonus);

        _goals.Add(checklistGoal);
        break;

      default:
        Console.WriteLine("Choose a valid option.");
        break;
    }

  }

  public void RecordEvent()
  {
    int index = 1;

    Console.WriteLine("The goals are:");

    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{index}. {goal.GetName()}");
      index++;
    }

    Console.Write("Which goal did you accomplish? ");
    int accomplishedGoal = int.Parse(Console.ReadLine());

    for (int i = 0; i < _goals.Count; i++)
    {
      // Get the Right Completed Goal by the Index
      if (i + 1 == accomplishedGoal)
      {
        _score += _goals[i].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {_goals[i].GetPoints()}!");
        Console.WriteLine($"You now have {_score}.");
      }
    }
  }

  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      outputFile.WriteLine(_score);

      foreach (Goal goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(filename);

    int index = 0;

    foreach (string line in lines)
    {
      if (index == 0)
      {
        _score = int.Parse(line);
        _oldScore = int.Parse(line);
      }
      else
      {
        string[] parts = line.Split(":");

        string className = parts[0];
        string classVariables = parts[1];

        switch (className)
        {
          case "SimpleGoal":
            string[] simpleGoalVars = classVariables.Split("~");

            // Get Class Member Variables
            string simpleGoalName = simpleGoalVars[0];
            string simpleGoalDes = simpleGoalVars[1];
            int simpleGoalPt = int.Parse(simpleGoalVars[2]);
            bool simpleGoalStatus = bool.Parse(simpleGoalVars[3]);

            SimpleGoal simpleGoal = new SimpleGoal(simpleGoalName, simpleGoalDes, simpleGoalPt, simpleGoalStatus);

            _goals.Add(simpleGoal);
            break;

          case "EternalGoal":
            string[] eternalGoalVars = classVariables.Split("~");

            // Get Class Member Variables
            string eternalGoalName = eternalGoalVars[0];
            string eternalGoalDes = eternalGoalVars[1];
            int eternalGoalPt = int.Parse(eternalGoalVars[2]);

            EternalGoal eternalGoal = new EternalGoal(eternalGoalName, eternalGoalDes, eternalGoalPt);

            _goals.Add(eternalGoal);
            break;

          case "ChecklistGoal":
            string[] checklistGoalVars = classVariables.Split("~");

            // Get Class Member Variables
            string checklistGoalName = checklistGoalVars[0];
            string checklistGoalDes = checklistGoalVars[1];
            int checklistGoalPt = int.Parse(checklistGoalVars[2]);
            int checklistGoalBonus = int.Parse(checklistGoalVars[3]);
            int checklistGoalTarget = int.Parse(checklistGoalVars[4]);
            int checklistGoalAmtCompleted = int.Parse(checklistGoalVars[5]);

            ChecklistGoal checklistGoal = new ChecklistGoal(checklistGoalName, checklistGoalDes, checklistGoalPt, checklistGoalTarget, checklistGoalBonus, checklistGoalAmtCompleted);

            _goals.Add(checklistGoal);
            break;

          default:
            Console.WriteLine("Invalid Goal in Goals");
            break;
        }
      }

      index++;

      // Store the Number of Old Goals to Keep Track of Goal
      // When a New Goal is Added
      _numberOfOldGoals++;
    }
  }

  public void QuitProgram()
  {
    if (_oldScore < _score || _numberOfOldGoals < _goals.Count)
    {
      Console.Write("Do you want to save changes before quitting (Yes or No)? ");
      string response = Console.ReadLine().ToLower();

      if (response == "yes")
      {
        SaveGoals();
      }
    }
  }
}