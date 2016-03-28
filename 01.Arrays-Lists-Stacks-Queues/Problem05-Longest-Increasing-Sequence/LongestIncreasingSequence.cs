using System;
using System.Collections.Generic;
using System.Linq;
class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> seq = Console.ReadLine().Split().Select(int.Parse).ToList();
       
        // hack
        int hack = 1;
        seq.Add(hack);  // this add one to the end of list and we have correct answers
        List<int> temp = new List<int>();           // temporary list
        List<int> longest = new List<int>();        // this list holds longest sequence
        for (int i = 0; i < seq.Count - 1; i++)
        {
            if (seq[i] < seq[i + 1])
            {
                temp.Add(seq[i]);
                continue;
            }
            if (seq[i] >= seq[i + 1])
            {
                temp.Add(seq[i]);
                if (temp.Count > longest.Count)
                {
                    longest.Clear();
                    for (int l = 0; l < temp.Count; l++)
                    {
                        longest.Add(temp[l]);
                    }
                }
                Console.WriteLine(string.Join(" ", temp));
                temp.Clear();
            }
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", longest));
    }
}