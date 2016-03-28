using System;
using System.Linq;
class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Selection Sort
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[i])   // swaping
                {
                    numbers[i] = numbers[i] + numbers[j];
                    numbers[j] = numbers[i] - numbers[j];
                    numbers[i] = numbers[i] - numbers[j];
                }
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}