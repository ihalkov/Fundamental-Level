using System;
using System.Linq;
class TerroristsWin
{
        static void Main()
        {
            string text = Console.ReadLine();
            char[] chArr = new char[text.Length];
            chArr = text.ToArray();

            int numOfBombs = NumberOfBombs(chArr);
            int[] bombsPower = BombsPower(chArr, numOfBombs);
            chArr = Destroy(chArr, numOfBombs, bombsPower);
            Console.WriteLine(string.Join("", chArr));
        }

        public static int NumberOfBombs(char[] chArr)
        {
            int numVerticBars = 0;
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] == '|')
                {
                    numVerticBars++;
                }
            }
            int numOfBombs = numVerticBars / 2;
            return numOfBombs;
        }
        public static int[] BombsPower(char[] chArr, int numOfBombs)
        {
            int verticBar = 0;
            int sumAscii = 0;
            int[] bombsPower = new int[numOfBombs];
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] == '|')
                {
                    verticBar++;
                    if (verticBar > numOfBombs * 2)
                    {
                        break;
                    }
                    if (verticBar % 2 == 0) // each even bar
                    {
                        int index = (verticBar / 2) - 1;          // index of bomb power
                        bombsPower[index] = sumAscii % 10;  // each bomb power
                        sumAscii = 0;
                    }
                }
                if (verticBar % 2 != 0 && chArr[i + 1] != '|') // one vertical bar, odd numbers
                {
                    sumAscii += chArr[i + 1];
                }
            }
            return bombsPower;
        }

        public static char[] Destroy(char[] chArr, int numOfBombs, int[] bombsPower)
        {
            int numVerticBars = 0;
            int[] containBars = new int[numOfBombs * 2];
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] == '|' && numVerticBars < numOfBombs * 2)
                {
                    numVerticBars++;
                    if (numVerticBars > numOfBombs * 2)
                    {
                        break;
                    }
                    if (numVerticBars % 2 != 0)
                    {
                        containBars[numVerticBars - 1] = i;
                    }
                    if (numVerticBars % 2 == 0)
                    {
                        containBars[numVerticBars - 1] = i;
                    }
                }
            }
            for (int i = 0; i < numOfBombs; i++)
            {
                int startDestroy = containBars[i * 2] - bombsPower[i];
                if (startDestroy < 0)
                {
                    startDestroy = 0;
                }
                int endDestroy = containBars[i * 2 + 1] + bombsPower[i];
                if (endDestroy > chArr.Length - 1)
                {
                    endDestroy = chArr.Length - 1;
                }
                for (int destroy = startDestroy; destroy <= endDestroy; destroy++)
                {
                    chArr[destroy] = '.';
                }
            }
            return chArr;
        }
}
