using System;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {
        // dimensions
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        int commandElements = 5; // swap and coordinates

        while (true)
        {
            string[] inputValues = Console.ReadLine().Split().ToArray();
            if (inputValues[0] == "END")
            {
                break;
            }
            // constrains
            if (inputValues.Length != commandElements)
            {
                Console.WriteLine("Invalid input");
                Array.Clear(inputValues, 0, inputValues.Length);
                continue;
            }
            bool rowOneConstrains = int.Parse(inputValues[1]) >= 0 && int.Parse(inputValues[1]) < matrix.GetLength(0);
            bool rowTwoConstrains = int.Parse(inputValues[3]) >= 0 && int.Parse(inputValues[3]) < matrix.GetLength(0);
            bool colOneConstrains = int.Parse(inputValues[2]) >= 0 && int.Parse(inputValues[2]) < matrix.GetLength(1);
            bool colTwoConstrains = int.Parse(inputValues[4]) >= 0 && int.Parse(inputValues[4]) < matrix.GetLength(1);
            if (inputValues[0] != "swap" || rowOneConstrains == false || 
                rowTwoConstrains == false || colOneConstrains == false || colTwoConstrains == false)
            {
                Console.WriteLine("Invalid input");
                Array.Clear(inputValues, 0, inputValues.Length);
                continue;
            }
            string temp = matrix[int.Parse(inputValues[1]), int.Parse(inputValues[2])];
            matrix[int.Parse(inputValues[1]), int.Parse(inputValues[2])] = matrix[int.Parse(inputValues[3]), int.Parse(inputValues[4])];
            matrix[int.Parse(inputValues[3]), int.Parse(inputValues[4])] = temp;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}