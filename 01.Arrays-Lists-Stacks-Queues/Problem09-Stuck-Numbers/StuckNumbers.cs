using System;
using System.Linq;
class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(' ').ToArray();
        bool isStuck = false;
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        if (a != b && a != c && a != d && b != c && b != d && c != d)
                        {
                            string left = numbers[a] + numbers[b];
                            string right = numbers[c] + numbers[d];
                            if (left == right)
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", numbers[a], numbers[b], numbers[c], numbers[d]);
                                isStuck = true;
                            }
                        }
                    }
                }
            }
        }
        if (isStuck == false)
        {
            Console.WriteLine("No");
        }
    }
}