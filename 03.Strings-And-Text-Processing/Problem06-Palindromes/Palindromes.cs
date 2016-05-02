//Problem 6.	Palindromes
//Write a program that extracts from a given text all palindromes,
//e.g.ABBA, lamal, exe and prints them on the console on a single line, 
//separated by comma and space.Use spaces, commas, dots, question marks
//and exclamation marks as word delimiters.Print only unique palindromes, sorted lexicographically.
// Input: Hi,exe? ABBA! Hog fully a string. Bob
// Output: a, ABBA, exe
using System;
using System.Text;
using System.Linq;
class Palindromes
{
    static void Main()
    {
        string text = "Hi,exe? ABBA! Hog fully a string. Bob";
        string[] words = text.Split(new char[] { ' ', ',', '.', '(', ')', ':', '!', '?', '|' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder palindromes = new StringBuilder();
        palindromes = Palindrome(words, palindromes);
        string[] result = palindromes.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Array.Sort(result);
        Console.WriteLine(string.Join(", ", result));
    }

    public static StringBuilder Palindrome(string[] words, StringBuilder palindromes)
    {
        for (int i = 0; i < words.Length; i++)
        {
            string tempWord = words[i];
            int lengthTempW = tempWord.Length;
            int count = 0;
            count = IsPalindrome(tempWord, lengthTempW, count);
            if (count == lengthTempW / 2)
            {
                palindromes.Append(tempWord);
                palindromes.Append(' ');
            }
        }
        return palindromes;
    }

    private static int IsPalindrome(string tempWord, int lengthTempW, int count)
    {
        for (int ch = 0; ch < lengthTempW / 2; ch++)
        {
            if (tempWord[ch] != tempWord[lengthTempW - 1 - ch])
            {
                break;
            }
            count++;
        }

        return count;
    }
}