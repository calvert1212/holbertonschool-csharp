using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int x = number % 10;

        if (x < 0)
        {
            x *= -1;
        }
        
        Console.Write(x);

        return x;
    }
}
