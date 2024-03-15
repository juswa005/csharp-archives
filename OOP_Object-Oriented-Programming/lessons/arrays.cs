using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int i;

        for (i = 0; i < 5; i++)
        {
            numbers[i] = i + 1;
        }

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

