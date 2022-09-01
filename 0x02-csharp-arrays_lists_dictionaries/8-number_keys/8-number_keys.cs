using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int x = 0;
        if (myDict == null)
        {
            return x;
        }
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            x++;
        }
        return x;
    }
}
