using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        int[] v = new int[4];
        v[3] = a + b + c;
        
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"v[{i}]:{v[i]}");
            Console.Write($"A:{a}");
            Console.Write($"  B:{b}");
            Console.WriteLine($"  C:{c}");
        }

        Console.ReadLine();
    }
}