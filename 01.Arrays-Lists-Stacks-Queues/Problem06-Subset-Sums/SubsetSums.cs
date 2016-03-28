using System;
using System.Collections.Generic;
using System.Linq;
class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        double combinations = Math.Pow(2, numbers.Count);  // number of combinations in this case 2^10 = 1024 :D
        List<int> subsets = new List<int>(); // in this list we will storage temporary each subset who is OK!
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
                    subsets.Add(numbers[arrIndex]);
                }
            }
            if (sum == n)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", subsets), sum);
                isMatch = true;
            }
            subsets.Clear();
        }
        if (isMatch == false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}