// Changed the color of the console text to show creativity

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        int userChoice;
        string activityName;
        string activityDescription;

        do
        {
            ShowMenu();
            userChoice = GetUserChoice();

            switch (userChoice)
            {
                case 1:
                    Console.Clear();

                    activityName = "Breathing Activity";
                    activityDescription = "This activity will help you relax by walking you through breathing in and out. Clear your mind and foucs on breathing";


                    BreathingActivity breathingActivity = new BreathingActivity(
                        activityName,
                        activityDescription);

                    // Show a welcome message and activity description to user
                    breathingActivity.DisplayStartingMessage();

                    // Get and set activity duration from user
                    Console.Write("How long do you want this session to last in seconds: ");
                    int activityDuration = int.Parse(Console.ReadLine());
                    breathingActivity.setDuration(activityDuration);

                    // Run activity
                    // Display loading animation
                    Console.WriteLine("Get ready...");
                    breathingActivity.ShowSpinner(5);

                    // Give a new line space after showing spinner
                    Console.WriteLine();
                    Console.WriteLine();

                    // Run the activity    
                    breathingActivity.Run();

                    // Display end message
                    breathingActivity.DisplayEndingMessage();

                    // Clear Console and reshow menu
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();

                    activityName = "Breathing Activity";
                    activityDescription = "This activity will help you reflect on times in your life when you have shown stength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                    ReflectingActivity reflectingActivity = new ReflectingActivity(activityName, activityDescription);

                    // Show a welcome message and activity description to user
                    reflectingActivity.DisplayStartingMessage();

                    // Get and set activity duration from user
                    Console.Write("How long do you want this session to last in seconds: ");
                    activityDuration = int.Parse(Console.ReadLine());
                    reflectingActivity.setDuration(activityDuration);

                      // Run activity
                    // Display loading animation
                    Console.WriteLine("Get ready...");
                    reflectingActivity.ShowSpinner(5);

                    Console.WriteLine();

                    Console.WriteLine("Consider the following prompts:");

                    Console.WriteLine();

                    // Display a random prompt
                    reflectingActivity.DisplayPrompt();

                    Console.WriteLine("When you have something in mind press enter to continue.");
                    Console.ReadLine();

                    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
                    Console.WriteLine("You may begin in: ");
                    reflectingActivity.ShowCountDown(4);

                    Console.Clear();

                    reflectingActivity.Run();

                    Console.WriteLine();

                    // Display end message
                    reflectingActivity.DisplayEndingMessage();

                    // Clear Console and reshow menu
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();

                    activityName = "Listing Activity";
                    activityDescription = "This activity will help you reflect on the good things of life by helping you list as many experience you can in an area.";

                    ListingActivity listingActivity = new ListingActivity(activityName, activityDescription);

                    // Show a welcome message and activity description to user
                    listingActivity.DisplayStartingMessage();

                    // Get and set activity duration from user
                    Console.Write("How long do you want this session to last in seconds: ");
                    activityDuration = int.Parse(Console.ReadLine());
                    listingActivity.setDuration(activityDuration);

                      // Run activity
                    // Display loading animation
                    Console.WriteLine("Get ready...");
                    listingActivity.ShowSpinner(5);

                    Console.WriteLine();

                    Console.WriteLine("List as many response as you can to the following prompts:");

                    Console.WriteLine();

                    // Display a random prompt
                    Console.WriteLine(listingActivity.GetRandomPrompt());

                    Console.WriteLine("You may begin in: ");
                    listingActivity.ShowCountDown(4);

                    listingActivity.Run();
                    Console.WriteLine($"You listed {listingActivity.GetListFromUser().Count} items!");

                    Console.WriteLine();

                    // Display end message
                    listingActivity.DisplayEndingMessage();

                    // Clear Console and reshow menu
                    Console.Clear();
                    break;
                default:
                    break;
            }
        } while (userChoice != 4);
    }

    static void ShowMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static int GetUserChoice()
    {
        return int.Parse(Console.ReadLine());
    }
}