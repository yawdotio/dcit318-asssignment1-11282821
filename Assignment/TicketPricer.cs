using System;

public class TicketPricer
{
    private static int TicketPrice = 10; // Base ticket price
    public static void Run()
    {
        Console.Write("Enter Your age: ");
        string? input = Console.ReadLine();
        int age;
        while (!int.TryParse(input, out age) || age < 0) { 
            Console.WriteLine("Invalid input. Please enter a valid age (0 or greater).");
            input = Console.ReadLine();
        }
        if (age < 13 || age > 65) {
            Console.WriteLine("Ticket Price: GHc 7.00 (Discounted for children and seniors)");
        }
        else if (age >= 13 && age <= 65)
        {
            Console.WriteLine($"Ticket Price: GHc {TicketPrice}.00 (Regular price)");
        }
        else
        {
            Console.WriteLine("Invalid age input. Please enter a valid age.");
        }
    }
}