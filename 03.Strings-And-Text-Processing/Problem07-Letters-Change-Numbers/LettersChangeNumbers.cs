using System;

class LettersChangeNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] strings = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);    // tabs too...
        double sum = 0;
        sum = TheSum(strings, sum);
        Console.WriteLine("{0:F2}", sum);
    }

    public static double TheSum(string[] strings, double sum)
    {
        for (int i = 0; i < strings.Length; i++)
        {
            string eachString = strings[i];
            int lengthEach = strings[i].Length;
            string letterBefore = eachString.Substring(0, 1);
            string letterAfter = eachString.Substring(lengthEach - 1, 1);
            string numBetween = eachString.Substring(1, lengthEach - 2);
            int number = int.Parse(numBetween);
            double b = BeforeNumberLetter(letterBefore, number);
            double a = AfterNumberLetter(letterAfter, b);
            sum += a;
        }

        return sum;
    }

    public static double AfterNumberLetter(string after, double num)
    {
        char ch = after[0];
        int pos = PosInAplhabet(ch);
        double result = 0;
        if (char.IsLower(ch))
        {
            result = num + pos;
        }
        else if (char.IsUpper(ch))
        {
            result = num - pos;
        }
        return result;
    }

    public static double BeforeNumberLetter(string before, double num)
    {
        char ch = before[0];
        int pos = PosInAplhabet(ch);
        double result = 0;
        if (char.IsLower(ch))
        {
            result = num * pos;
        }
        else if (char.IsUpper(ch))
        {
            result = num / pos;
        }
        return result;
    }

    public static int PosInAplhabet(char ch)
    {
        int pos = 0;
        if (char.IsUpper(ch))
        {
            pos = ch - 64;
        }
        else if (char.IsLower(ch))
        {
            pos = ch - 96;
        }
        return pos;
    }
}