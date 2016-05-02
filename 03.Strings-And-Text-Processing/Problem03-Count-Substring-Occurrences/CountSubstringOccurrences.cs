using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string substring = Console.ReadLine();
        int index = inputText.ToLower().IndexOf(substring.ToLower());     // first occurence of "r" ->> index
        int occurences = 0;
        if (index < 0)
        {
            Console.WriteLine(occurences);
        }
        if (index >= 0)
        {
            occurences = 1;
            PrintOccurencesOfSubstring(inputText, index, occurences, substring);
        }

        
    }

    public static void PrintOccurencesOfSubstring(string inputText, int index, int occurences, string substring)
    {
        while (true)
        {
            index++;
            index = inputText.ToLower().IndexOf(substring.ToLower(), index);  // begin from last occurence +1
            if (index < 0)
            {
                break;
            }
            occurences++;
        }
        Console.WriteLine(occurences);
    }
}