using System;

class Array
{
    public static void Reverse(int[] arr)
    {
        if (arr != null)
        {
            for (int loop = arr.Length - 1; x >= 0; x--)
            {
                Console.Write(arr[x]);
                if (x > 0)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}
