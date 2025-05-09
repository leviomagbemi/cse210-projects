using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int number;
        int sum = 0;
        int largestNumber = 0;
        int smallestPostiveNumber = 1000;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Add number to List
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numberList.Add(number);
            }
            
        } while (number != 0);
        
        // Get sum of all the numbers in the List
        foreach (int num in numberList)
        {
            sum += num;
        }

        // Find the largest number
        for (int i = 0; i < numberList.Count; i++)
        {
            if (numberList[i] > largestNumber)
            {
                largestNumber = numberList[i];
            }
        }

        // Find the smallest positive number
        for (int i = 0; i < numberList.Count; i++)
        {
            if ( smallestPostiveNumber > numberList[i] && numberList[i] > 0)
            {
                
                smallestPostiveNumber = numberList[i];
            }
        }

        // Calculate average
        int average = sum / numberList.Count;

        // Output results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPostiveNumber}");

        // Arrange and display numbers in ascending order
        numberList.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }

    }
}