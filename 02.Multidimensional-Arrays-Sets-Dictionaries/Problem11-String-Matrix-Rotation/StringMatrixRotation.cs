using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class StringMatrixRotation
{
    static void Main()
    {
        string command = Console.ReadLine();
        int deg = ExtractNumber(command);
        string input = Console.ReadLine();
        List<List<char>> lines = new List<List<char>>();
        List<char> holdInput;
        while (input != "END")
        {
            holdInput = input.ToCharArray(0, input.Length).ToList();
            lines.Add(holdInput);
            input = Console.ReadLine();
        }

        int lengthOfMatrix = FindLengthOfMatrix(lines);
        char[,] straight = StraightMatrix(lines, lengthOfMatrix);

        if (deg == 0 || deg % 360 == 0)
        {
            for (int r = 0; r < straight.GetLength(0); r++)
            {
                for (int c = 0; c < straight.GetLength(1); c++)
                {
                    Console.Write("{0}", straight[r, c]);
                }
                Console.WriteLine();
            }
        }
        if (deg == 90 || deg % 360 == 90)
        {
            NinethyDegRotate(straight);
        }
        if (deg == 180 || deg % 360 == 180)
        {
            OneEightZeroDeg(straight);
        }
        if (deg == 270 || deg % 360 == 270)
        {
            TwoSevenZeroDeg(straight);
        }

    }

    public static int ExtractNumber(string text)
    {
        string s = text;
        string format = @"\b\W\w+\W";
        Regex regex = new Regex(format);
        Match match = regex.Match(s);
        string value = "";
        value = match.Value;
        string txtResult = "";
        for (int i = 1; i < value.Length - 1; i++)
        {
            txtResult += value[i];
        }
        int numResult = int.Parse(txtResult);
        return numResult;
    }
    public static int FindLengthOfMatrix(List<List<char>> lines)
    {
        int lengthOfMatrix = 0;
        for (int row = 0; row < lines.Count; row++)
        {
            int tempLength = lines[row].Count;
            if (lengthOfMatrix < tempLength)
            {
                lengthOfMatrix = tempLength;
            }
        }
        return lengthOfMatrix;
    }
    public static char[,] StraightMatrix(List<List<char>> lines, int lengthOfMatrix)
    {
        int rowsInMatrix = lines.Count;
        int colsInMatrix = lengthOfMatrix;
        char[,] matrix = new char[rowsInMatrix, colsInMatrix];
        for (int rowMatrix = 0; rowMatrix < rowsInMatrix; rowMatrix++)
        {
            for (int colMatrix = 0; colMatrix < colsInMatrix; colMatrix++)
            {
                int rowLength = lines[rowMatrix].Count;
                if (colMatrix > rowLength - 1)
                {
                    matrix[rowMatrix, colMatrix] = ' ';           // pad with spaces
                    continue;
                }
                matrix[rowMatrix, colMatrix] = lines[rowMatrix][colMatrix];
            }
        }
        return matrix;
    }       // 0 deg
    public static void NinethyDegRotate(char[,] straight)
    {
        int rows = straight.GetLength(1);
        int cols = straight.GetLength(0);
        int maxCol = cols - 1;
        char[,] ninethyDeg = new char[rows, cols];
        for (int c = 0; c < cols; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                int colOfStraightMatrix = r;
                int rowOfStraightMatrix = cols - 1 - c;
                ninethyDeg[r, c] = straight[rowOfStraightMatrix, colOfStraightMatrix];
            }
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write("{0}", ninethyDeg[r, c]);
            }
            Console.WriteLine();
        }
    }                                  // 90 deg
    public static void OneEightZeroDeg(char[,] straight)
    {
        int rows = straight.GetLength(0);
        int cols = straight.GetLength(1);
        char[,] ninethyDeg = new char[rows, cols];
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int rowOfStraightMatrix = rows - 1 - r;
                int colOfStraightMatrix = cols - 1 - c;
                ninethyDeg[r, c] = straight[rowOfStraightMatrix, colOfStraightMatrix];
            }
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write("{0}", ninethyDeg[r, c]);
            }
            Console.WriteLine();
        }
    }                                   // 180 deg
    public static void TwoSevenZeroDeg(char[,] straight)
    {
        int rows = straight.GetLength(1);
        int cols = straight.GetLength(0);
        int maxCol = cols - 1;
        char[,] ninethyDeg = new char[rows, cols];
        for (int c = 0; c < cols; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                int colOfStraightMatrix = rows - 1 - r;
                int rowOfStraightMatrix = c;
                ninethyDeg[r, c] = straight[rowOfStraightMatrix, colOfStraightMatrix];
            }
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write("{0}", ninethyDeg[r, c]);
            }
            Console.WriteLine();
        }
    }                                   // 270 deg
}