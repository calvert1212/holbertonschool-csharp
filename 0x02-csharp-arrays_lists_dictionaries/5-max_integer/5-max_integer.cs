using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int x = myList[0];
        foreach (var element in myList)
        {
            if (x < element)
            {
                x = element;
            }
        }
        return x;
    }
}
