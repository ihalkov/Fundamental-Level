using System;
using System.Collections.Generic;
using System.Linq;
class SortedSubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        double combinations = Math.Pow(2, numbers.Count);  // number of combinations in this case 2^10 = 1024 :D
        List<int> subset = new List<int>(); // in this list we will storage temporary each subset who is OK!
        List<List<int>> storageOfSubsets = new List<List<int>>();
        bool isMatch = false;
        for (int c = 1; c < combinations; c++)
        {
            int sum = 0;
            for (int arrIndex = 0; arrIndex < numbers.Count; arrIndex++)
            {
                int mask = c & (1 << arrIndex); // we move 1 arrIndex times
                if (mask != 0)
                {
                    sum += numbers[arrIndex];
                    subset.Add(numbers[arrIndex]);
                }
            }
            if (sum == n)
            {
                storageOfSubsets.Add(subset.ToList());
                isMatch = true;
            }
            subset.Clear();
        }
        List<List<int>> sorted = storageOfSubsets.OrderBy(p => p.Count).ThenBy(list => list[0]).ToList();   // orderBy sort by length of row, thenBy sort of list[0]
        foreach (var subsetRow in sorted)
        {
            Console.Write(string.Join(" + ", subsetRow));       // print each list
            Console.WriteLine(" = {0}", n);                     // sum
        }
        if (isMatch == false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}