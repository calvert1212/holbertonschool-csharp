using System;

class Line
{
    public static void PrintDiagonal(int len)
    {
        if (len > 0)
        {
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
        Console.WriteLine();
    }
}
