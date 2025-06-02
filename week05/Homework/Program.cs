using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Levi Omagbemi", "Inheritance application");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment(
            "Levi Omagbemi",
            "Algebra",
            "7.3",
            "8-13"
            );
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment(
            "Levi Omagbemi",
            "Nigerian History",
            "The Nigerian Civil War (1967–1970)"
        );
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}