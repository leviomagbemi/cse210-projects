using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string sign;
        
        // Ask user for grade percentage
        // And convert grade to number
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        
        // Get last digit of grade from userInput String
        // Convert from char data type to string
        // Convert from string to number
        string lastValue = userInput[1].ToString();
        int lastdigit = int.Parse(lastValue);
        
        // Check grade percentage and assign a Letter
        if(grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check grade last digit and assign a sign
        if(lastdigit >= 7 && letter != "A")
        {
            sign = "+";
        }
        else if (lastdigit < 3 && letter != "F" )
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        // Display output in console
        Console.WriteLine(sign + letter);
    }
}