using System;
using System.Collections.Generic;


public class TriangleIdentifier
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Enter the sides of the triangle separated by space( )");
            string? input = Console.ReadLine();
            try
            {
                if (input == null)
                    throw new FormatException("No input provided.");

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Split input by spaces and remove empty entries
                if (parts.Length != 3)
                    throw new FormatException("Please enter exactly three sides.");

                double side1 = double.Parse(parts[0]);
                double side2 = double.Parse(parts[1]);
                double side3 = double.Parse(parts[2]);

                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                    throw new FormatException("Sides must be positive numbers.");

                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("Triangle type: Equilateral");
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                    Console.WriteLine("Triangle type: Isosceles");
                else
                    Console.WriteLine("Triangle type: Scalene");
                break; // Exit the loop after successful identification
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred. Please try again.");
            }
        }

    }
}