using System;
using System.Collections.Generic;
using System.Linq;

class CollectTheCoins

{
    static void Main()
    {
        List<List<string>> board = new List<List<string>>();
        int rowsOfBoard = 4;
        for (int r = 0; r < rowsOfBoard; r++)
        {
            board.Add(Console.ReadLine().Split().ToList());     // split with spaces
        }
        string movementCommands = Console.ReadLine();
        // coordinates
        int row = 0;
        int col = 0;
        int coins = 0;
        int hitWall = 0;
        for (int command = 0; command < movementCommands.Length; command++)
        {
            switch (movementCommands[command])
            {
                case '>':
                    col++;
                    if (col > board[row].Count)
                    {
                        hitWall++;
                        col--;
                        continue;
                    }
                    break;
                case '<':
                    col--;
                    break;
                case 'V':
                    row++;
                    if (col > board[row].Count)
                    {
                        hitWall++;
                        row--;
                        continue;
                    }
                    break;
                case '^':
                    row--;
                    break;
                default:
                    break;
            }
            if (row < 0)
            {
                hitWall++;
                row++;
                continue;
            }
            if (col < 0)
            {
                hitWall++;
                col++;
                continue;
            }
            if (board[row][col] == "$")
            {
                coins++;
            }
        }
        Console.WriteLine(coins);
        Console.WriteLine(hitWall);
    }
}