using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            for (int loop = 0; loop < n; loop++)
            {
                Console.WriteLine(myList[loop]);
                count++;
            }
            return count;
        }
        catch
        {
            return count;
        }
    }
}
