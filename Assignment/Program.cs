using System;

while (true)
{
    Console.WriteLine("DCIT Programming Assignment II");
    Console.WriteLine("1. Grade Calculator");
    Console.WriteLine("2. Ticket Price Calculator");
    Console.WriteLine("3. Triangle Type Identifier");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option (1-4): ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            GradeCalculator.Run();
            break;
        case "2":
            TicketPricer.Run();
            break;
        case "3":
            TriangleIdentifier.Run();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
    Console.WriteLine();
}
