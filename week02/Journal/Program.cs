using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int userChoice = PromptUser();

        while (userChoice != 5)
        {
            // Write
            if (userChoice == 1)
            {
                // Display Random Prompt
                // Get Response
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string userResponse = Console.ReadLine();

                // Create Entry
                Entry entry = new Entry();

                // Get and Store Current Date
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                // Store promptText and entryText
                entry._promptText = prompt;
                entry._entryText = userResponse;

                // Store Entry in Journal
                journal.AddNewEntry(entry);

                // Re-prompt the User
                userChoice = PromptUser();
            }
            // Display All Entries
            else if (userChoice == 2)
            {
                journal.DisplayAll();

                // Re-prompt the User
                userChoice = PromptUser();
            }
            // Load
            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);

                // Re-prompt User
                userChoice = PromptUser();
            }
            // Save
            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);

                // Re-prompt User
                userChoice = PromptUser();
            }

        }
    }

    static int PromptUser()
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            int userChoice = int.Parse(Console.ReadLine());

            return userChoice;
        }
}