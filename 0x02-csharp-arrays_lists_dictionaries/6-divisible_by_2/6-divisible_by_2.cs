using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return null;
        }
        var x = new List<bool>();
        foreach (var element in myList)
        {
            x.Add(element % 2 == 0);
        }
        return x;
    }
}
