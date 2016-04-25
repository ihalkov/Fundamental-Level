using System;
using System.Collections.Generic;
using System.Linq;
class PlusRemove
{
    static void Main()
    {
        // input
        string input = Console.ReadLine();
        List<List<char>> lines = new List<List<char>>();
        List<char> holdInput;
        while (input != "END")
        {
            holdInput = input.ToCharArray(0, input.Length).ToList();
            lines.Add(holdInput);
            input = Console.ReadLine();
        }
        int maxLength = 0;
        for (int row = 0; row < lines.Count; row++)             // num of rows
        {
            int lengthOfRow = lines[row].Count;
            if (maxLength < lengthOfRow)
            {
                maxLength = lengthOfRow;
            }
        }
        // copy plus shapes
        int numOfRows = lines.Count;
        int numOfCols = maxLength;
        char[,] pattern = new char[numOfRows, numOfCols];     // to hold plus shapes
        for (int row = 0; row < lines.Count; row++)             // num of rows
        {
            for (int col = 0; col < lines[row].Count; col++)   // length of each row
            {
                // constraints
                if (row + 1 > lines.Count - 2 || col - 1 < 0 || col + 1 > lines[row + 1].Count - 1 || row + 2 > lines.Count - 1 
                    || col > lines[row + 1].Count - 1 || col > lines[row + 2].Count - 1)
                {
                    continue;
                }
                char[] tempCross = new char[5];
                tempCross[0] = lines[row][col];
                tempCross[1] = lines[row + 1][col - 1];
                tempCross[2] = lines[row + 1][col];
                tempCross[3] = lines[row + 1][col + 1];
                tempCross[4] = lines[row + 2][col];
                bool isAlphabet = IsAlphabeticSymbols(tempCross);
                bool isEqualAlpabetSymbols = EqualAlphabetSymbols(tempCross);
                if ((isAlphabet && isEqualAlpabetSymbols) == true || isEqualAlpabetSymbols == true)
                {
                    pattern[row, col] = tempCross[0];
                    pattern[row + 1, col - 1] = tempCross[1];
                    pattern[row + 1, col] = tempCross[2];
                    pattern[row + 1, col + 1] = tempCross[3];
                    pattern[row + 2, col] = tempCross[4];
                }
            }
        }
        // delete patern in lines
        DeletePatern(lines, pattern);
        // Print, shape
        foreach (var item in lines)
        {
            Console.WriteLine(string.Join("", item));
        }
    }
    public static bool IsAlphabeticSymbols(char[] tempCross)
    {
        bool isAlphabetic = true;
        for (int ch = 0; ch < tempCross.Length; ch++)
        {
            // x >= 65 || x <= 90 || x >= 97 || x <= 122
            char x = tempCross[ch];
            if ((x >= 65 && x <= 90) || (x >= 97 && x <= 122))
            {
                continue;
            }
            isAlphabetic = false;
            break;
        }
        return isAlphabetic;
    }
    public static bool EqualAlphabetSymbols(char[] tempCross)
    {
        bool isTrue = true;
        int countTrues = 0;

        for (int i = 0; i < tempCross.Length - 1; i++)
        {
            // a = b || a = b - 32 || a = b + 32
            char a = tempCross[i];
            char b = tempCross[i + 1];
            if (a == b || a == b - 32 || a == b + 32)
            {
                countTrues++;
            }
        }
        if (countTrues < 4)
        {
            isTrue = false;
        }
        return isTrue;
    }
    public static bool isEqualNonAlphabeticSymbols(char[] tempCross)
    {
        bool isEqual = true;
        int countTrues = 0;

        for (int i = 0; i < tempCross.Length - 1; i++)
        {
           
            char a = tempCross[i];
            char b = tempCross[i + 1];
            if (a == b) // a = b, b = c, c = d, d = e
            {
                countTrues++;
            }
        }
        if (countTrues < 4)
        {
            isEqual = false;
        }
        return isEqual;
    }
    public static List<List<char>> DeletePatern(List<List<char>> lines, char[,] pattern)
    {
        for (int row = 0; row < lines.Count; row++)             // num of rows
        {
            List<int> positions = new List<int>();
            for (int col = 0; col < lines[row].Count; col++)   // length of each row
            {
                if (lines[row][col] == pattern[row, col])
                {
                    positions.Add(col);
                }
            }
            int count = 0;
            for (int pos = 0; pos < positions.Count; pos++)
            {
                lines[row].RemoveAt(positions[pos] - count);
                count++;
            }
        }
        return lines;
    }
}