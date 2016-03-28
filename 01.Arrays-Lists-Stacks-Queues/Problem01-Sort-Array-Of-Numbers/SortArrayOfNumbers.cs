using System;
using System.Linq;
class SortArrayOfNumbers
{
    static void Main()
    {
        // read array of numbers on single row separated by space
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(numbers); // sort
        Console.WriteLine(string.Join(" ", numbers));   // print
    }
}