using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int x = i + 1; x < 10; x++)
            {
                if (i != 8)
                {
                    Console.Write("{0}{1}, ", i, x);
                }
                else
                {
                    Console.WriteLine("{0}{1}", i, x);
                }
            }
        }
    }
}
