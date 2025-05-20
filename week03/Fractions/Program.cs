using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Get and Set fraction1
        Console.WriteLine("Fraction one:");
        Console.WriteLine($"{fraction1.GetTop()}, {fraction1.GetBottom()}");
        fraction1.SetTop(1);
        fraction1.SetBottom(1);
        Console.WriteLine($"{fraction1.GetTop()}, {fraction1.GetBottom()}");

        // Get and Set fraction2
        Console.WriteLine("Fraction two:");
        Console.WriteLine($"{fraction2.GetTop()}, {fraction2.GetBottom()}");
        fraction2.SetTop(5);
        fraction2.SetBottom(1);
        Console.WriteLine($"{fraction2.GetTop()}, {fraction2.GetBottom()}");

        // Get and Set fraction3
        Console.WriteLine("Fraction three:");
        Console.WriteLine($"{fraction3.GetTop()}, {fraction3.GetBottom()}");
        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine($"{fraction3.GetTop()}, {fraction3.GetBottom()}");

        // Test Constructor and Methods
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}