using System;
using System.Runtime;

public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;


  public ChecklistGoal(
    string name,
    string description,
    int points,
    int target,
    int bonus
  ) : base(name, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
  }

  public ChecklistGoal(
    string name,
    string description,
    int points,
    int target,
    int bonus,
    int amountCompleted
  ) : base(name, description, points)
  {
    _amountCompleted = amountCompleted;
    _target = target;
    _bonus = bonus;
  }


  public override int RecordEvent()
  {
    _amountCompleted++;

    return _amountCompleted == _target ? base.GetPoints() + _bonus : base.GetPoints();
  }

  public override bool IsComplete()
  {
    return true ? _amountCompleted >= _target : false;
  }

  public override string GetDetailsString()
  {
    return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal:{base.GetName()}~{base.GetDescription()}~{base.GetPoints()}~{_bonus}~{_target}~{_amountCompleted}";
  }
}