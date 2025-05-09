using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int userSquaredNumber = SquaredNumber(favoriteNumber);
        DisplayResult(userName: userName, squaredNumber: userSquaredNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userValue = int.Parse(Console.ReadLine());

        return userValue;
    }

    static int SquaredNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        string result = $"{userName}, the square of your number is {squaredNumber}.";

        Console.WriteLine(result);
    }
}