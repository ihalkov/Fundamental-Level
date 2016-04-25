using System;
using System.Collections.Generic;

class FillTheMatrix
{
    static void Main()
    {
        // Print Matrix Of Size N x N
        int n = 4;
        int[,] matrix = new int[n, n];
        int rowLength = matrix.GetLength(0);
        int colLength = matrix.GetLength(1);
        int count = 1;
        Console.WriteLine("<<< Pattern A >>>");
        PatternA(rowLength, colLength, count, matrix);
        Console.WriteLine("<<< Pattern B >>>");
        PatternB(rowLength, colLength, count, matrix);
    }

    static void PatternA(int rowLength, int colLength, int count, int[,] matrix)
    {
        for (int col = 0; col < rowLength; col++)
        {
            for (int row = 0; row < colLength; row++)
            {
                matrix[row, col] = count;
                count++;
            }
        }

        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void PatternB(int rowLength, int colLength, int count, int[,] matrix)
    {
        for (int col = 0; col < rowLength; col++)
        {
            if (col % 2 != 0)
            {
                for (int row = colLength - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = 0; row < colLength; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }

        }

        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}