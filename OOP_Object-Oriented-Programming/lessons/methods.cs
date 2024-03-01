using System;

class Program
{
    static void GreetUser()
    {
        Console.WriteLine("Welcome to C# programming!");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int result;

        GreetUser();

        result = Add(5, 3);
        Console.WriteLine("Sum: " + result);
    }
}

