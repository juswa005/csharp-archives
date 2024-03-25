using System;

class Program
{
    static void Main()
    {
        int choice;
        double a, b;

        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");

        Console.Write("Choose operation: ");
        choice = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = double.Parse(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine("Result: " + (a + b));
        else if (choice == 2)
            Console.WriteLine("Result: " + (a - b));
        else if (choice == 3)
            Console.WriteLine("Result: " + (a * b));
        else if (choice == 4)
            Console.WriteLine("Result: " + (a / b));
        else
            Console.WriteLine("Invalid choice");
    }
}

