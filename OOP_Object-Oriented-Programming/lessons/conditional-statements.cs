using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Positive number");
        }
        else
        {
            Console.WriteLine("Zero or negative number");
        }
    }
}

