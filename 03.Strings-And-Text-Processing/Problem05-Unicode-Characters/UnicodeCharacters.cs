//  Problem 5.Unicode Characters
//  Write a program that converts a string to a sequence of C# Unicode character literals. Examples:
// Input: Hi!
// Output: \u0048\u0069\u0021
using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string txt = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        foreach (char ch in txt)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)ch));
        }
        Console.WriteLine(sb.ToString());
       // string ch = String.Format("{0:x4}", (int)txt[1]);
       // Console.WriteLine(ch);
    }
}