// Showed Creativity by Detecting if There is a Change and 
// Ask User to Save Changes Before Quitting Program

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int userOption;

        do
        {
            goalManager.DisplayPlayerInfo();
            goalManager.Start();

            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    goalManager.ListGoalName();
                    goalManager.CreateGoal();
                    break;

                case 2:
                    goalManager.ListGoalDetails();
                    break;

                case 3:
                    goalManager.SaveGoals();
                    break;

                case 4:
                    goalManager.LoadGoals();
                    break;

                case 5:
                    goalManager.RecordEvent();
                    break;
                
                case 6:
                    goalManager.QuitProgram();
                    Console.WriteLine("Quiting program.....");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("Choose a valid option.");
                    break;
            }

        } while (userOption != 6);
    }
}