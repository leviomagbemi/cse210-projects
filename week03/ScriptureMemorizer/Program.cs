// I added the hint feature to the program to show creativity
// This will enable the user to 'hint' to show random words that
// Has been hidden to make the program more user friendly.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Matthew", 5, 13);
        Scripture scripture = new Scripture(reference, "You are the salt of the earth; But if a salt loses its flavor how is it seasoned. It is then good for nothing but to be thrown out and trampled underfoot by men.");

        DisplayTextPrompt(scripture);
        string userResponse = Console.ReadLine().ToLower();


        while (!scripture.IsCompletelyHidden() && userResponse != "quit")
        {
            Console.Clear();

            // Get 3 Random Number Based on Scripture Lenght
            Random random = new Random();
            int randomNumber1 = random.Next(0, scripture.GetNumberOfWords());
            int randomNumber2 = random.Next(0, scripture.GetNumberOfWords());
            int randomNumber3 = random.Next(0, scripture.GetNumberOfWords());

            if (userResponse == "hint")
            {
                // Show 3 Words Randomly
                scripture.ShowRandomWords(randomNumber1);
                scripture.ShowRandomWords(randomNumber2);
                scripture.ShowRandomWords(randomNumber3);
            }
            else
            {
                // Hide 3 Words Randomly
                scripture.HideRandomWords(randomNumber1);
                scripture.HideRandomWords(randomNumber2);
                scripture.HideRandomWords(randomNumber3);
            }

            DisplayTextPrompt(scripture);
            userResponse = Console.ReadLine().ToLower();
        }
    }

    static void DisplayTextPrompt(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Please press enter to continue or type 'quit' to finish or type hint to hint: ");
    }
}