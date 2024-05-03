using System;
using System.Collections.Generic;

class Program
{
    static int Stones(string J, string S)
    {
        HashSet<char> jewelTypes = new HashSet<char>(J);
        int count = 0;
        foreach (char stone in S)
        {
            if (jewelTypes.Contains(stone))
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        string J = "i";
        string S = "jksdfgiasdy";
        int result = Stones(J, S);
        Console.WriteLine(result); 
    }
}
