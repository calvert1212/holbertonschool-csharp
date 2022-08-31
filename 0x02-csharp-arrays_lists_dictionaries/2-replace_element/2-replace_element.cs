using System;

class Array
{
    public static int[] ReplaceElement(int[] arr, int x, int n)
    {
        if (x < 0 || x >= arr.Length)
        {
            Console.WriteLine("Index out of range");
            return arr;
        }
        arr[x] = n;
        return arr;
    }
}
