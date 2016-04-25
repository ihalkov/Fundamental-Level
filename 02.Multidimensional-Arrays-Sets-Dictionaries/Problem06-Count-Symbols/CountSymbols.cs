using System;
using System.Collections.Generic;
using System.Linq;
class CountSymbols
{
    static void Main()
    {
        
        List<char> text = new List<char>(Console.ReadLine().ToList());
        text.Sort();
        int[] count = new int[text.Count];
        Dictionary<char, int> result = new Dictionary<char, int>();
        for (int ch = 0; ch < text.Count; ch++)
        {
            count[ch] = 1;        // count["S"] = 0;
            for (int otherCh = ch + 1; otherCh < text.Count; otherCh++)
            {
                if (text[ch] == text[otherCh])
                {
                    count[ch]++;
                    text.RemoveAt(otherCh);
                    otherCh--;
                }
            }
            // dictionary.
            result[text[ch]] = count[ch];
        }
        foreach (var item in result)
        {
            Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
        }
    }
}