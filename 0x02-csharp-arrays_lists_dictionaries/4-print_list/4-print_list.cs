using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int s)
    {
        if (s < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        var n = new List<int>();
        for (int x = 0; x < s; x++)
        {
            n.Add(x);
            Console.Write(x);
            if (x < s - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return n;
    }
}
