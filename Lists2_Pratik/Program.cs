using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveler = new List<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahve = Console.ReadLine();
            kahveler.Add(kahve);
        }

        Console.WriteLine("\nGirilen Kahve İsimleri:");
        foreach (var kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}
