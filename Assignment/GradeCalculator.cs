using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.Write("Enter numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letter = grade >= 90 ? "A" :
                            grade >= 80 ? "B" :
                            grade >= 70 ? "C" :
                            grade >= 60 ? "D" : "F";
            Console.WriteLine($"Letter grade: {letter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}