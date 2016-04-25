using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        // matrix size N x M
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();  // row, cols
        int[,] matrix = new int[size[0], size[1]];
        int[] input = new int[size[1]];
        for (int row = 0; row < size[0]; row++)
        {
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < size[1]; col++)
            {
                matrix[row, col] = input[col];
            }
            Array.Clear(input, 0, input.Length);
        }
        int sum = int.MinValue;
        int maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int sizePlatform = 3;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("Sum = {0}", maxSum);
        for (int row = bestRow; row < sizePlatform + bestRow; row++)
        {
            for (int col = bestCol; col < sizePlatform + bestCol; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}