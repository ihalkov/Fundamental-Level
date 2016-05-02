using System;
using System.Text;
class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder reverse = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse.Append(input[i]);
        }
        Console.WriteLine(string.Join("", reverse));
    }
}