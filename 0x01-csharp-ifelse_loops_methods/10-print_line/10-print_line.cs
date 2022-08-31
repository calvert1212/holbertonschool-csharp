using System;

class Line
{
    public static void PrintLine(int len)
    {
        if (len > 0)
        {
            for (int x = 0; x < len; x++)
            {
                Console.Write("_");
            }
        }
        Console.WriteLine();
    }
}
