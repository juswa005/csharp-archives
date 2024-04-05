using System;

class Program
{
    static void Main()
    {
        string[] names = new string[3];
        int i;

        for (i = 0; i < 3; i++)
        {
            Console.Write("Enter student name: ");
            names[i] = Console.ReadLine();
        }

        Console.WriteLine("\nStudent List:");
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
}

