using System;
using System.Linq;
class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  // count input numbers
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        bool isPythagorean = false;
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (numbers[a] <= numbers[b] && (Math.Pow(numbers[c], 2) == Math.Pow(numbers[a], 2) + Math.Pow(numbers[b], 2)))
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[a], numbers[b], numbers[c]);
                        isPythagorean = true;
                    }
                }
            }
        }
        if (isPythagorean == false)
        {
            Console.WriteLine("No");
        }
    }
}