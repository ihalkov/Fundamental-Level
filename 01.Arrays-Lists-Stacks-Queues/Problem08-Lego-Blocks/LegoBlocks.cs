using System;
using System.Collections.Generic;
using System.Linq;
class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());                  // rows in each of lists
        List<List<int>> firstJagged = new List<List<int>>();
        List<List<int>> secondJagged = new List<List<int>>();
        List<List<int>> matrix = new List<List<int>>();

        JaggedList(firstJagged, n);
        JaggedList(secondJagged, n);
        for (int i = 0; i < n; i++)
        {
            secondJagged[i].Reverse();  // here we reverse each row in secondJagged list
        }
        bool isMatch = true;
        for (int f = 0; f < n; f++)
        {
            for (int s = 0; s < secondJagged[f].Count; s++)
            {
                firstJagged[f].Add(secondJagged[f][s]);     // for Example: f = 1, s = from 0 - length of secondJagged length,
            }                                               
            matrix.Add(firstJagged[f]);
        }

        for (int match = 0; match < matrix.Count - 1; match++)
        {
            if (matrix[match].Count != matrix[match + 1].Count)
            {
                isMatch = false;
            }
        }
        if (isMatch == true)
        {
            foreach (var elementsInRow in matrix)
            {
                Console.WriteLine("[{0}]", string.Join(", ", elementsInRow));
            }
        }
        else
        {
            int allElements = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                allElements += matrix[i].Count;
            }
            Console.WriteLine("The total number of cells is: {0}", allElements);
        }
    }

    static List<List<int>> JaggedList(List<List<int>> list, int n)
    {
        for (int i = 0; i < n; i++)
        {
            list.Add(Console.ReadLine().Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).Select(int.Parse).ToList());     // add row of list elements, and we use where IsNullOrWhiteSpace to remove whitespaces
        }
        return list;
    }
}