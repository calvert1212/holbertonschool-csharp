using System;

class Array
{
    public static int elementAt(int[] arr, int x)
    {
        if (x < 0 || x >= arr.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return arr[x];
    }
}
