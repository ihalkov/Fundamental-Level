using System;
using System.Collections.Generic;
using System.Linq;
class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        // read floating point numbers
        double[] floats = Console.ReadLine().Split().Select(double.Parse).ToArray();
        List<double> round = new List<double>();
        List<double> floatingPoint = new List<double>();
        for (int i = 0; i < floats.Length; i++)
        {
            if (floats[i] % 1 == 0)
            {
                round.Add(floats[i]);
            }
            else
            {
                floatingPoint.Add(floats[i]);
            }
        }

        Console.WriteLine("[{0}] -> min: {1:.##}, max: {2:.###}, sum: {3:.###}, avg: {4:.##}",
            string.Join(", ", floatingPoint), floatingPoint.Min(), floatingPoint.Max(), floatingPoint.Sum(), floatingPoint.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
            string.Join(", ", round), round.Min(), round.Max(), round.Sum(), round.Average());
    }
}