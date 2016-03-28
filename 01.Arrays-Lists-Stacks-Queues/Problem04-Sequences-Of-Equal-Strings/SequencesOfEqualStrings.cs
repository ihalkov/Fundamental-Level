using System;
using System.Collections.Generic;
using System.Linq;
class SequencesOfEqualStrings
{
    static void Main()
    {
        // declarate list
        List<string> seq = Console.ReadLine().Split().ToList();
        List<string> tempList = new List<string>();
        for (int i = 0; i < seq.Count; i++)
        {
            if (i == seq.Count - 1)
            {
                tempList.Add(seq[i]);
                Console.WriteLine(string.Join(" ", tempList));
            }
            else if (seq[i] == seq[i + 1])
            {
                tempList.Add(seq[i + 1]);
            }
            else
            {
                tempList.Add(seq[i]);
                Console.WriteLine(string.Join(" ", tempList));
                tempList.RemoveAll((p => p == seq[i]));
            }
        }
    }
}