using System;

class StringLength
{
    static void Main()
    {
        // input ->> max 20 chars
        string input = Console.ReadLine();
        int inputLength = input.Length;
        int stringMaxCharacters = 20;
        string result = "";
        if (inputLength < stringMaxCharacters)
        {
            result = AddAsterisk(input, inputLength);
        }
        if (inputLength.Equals(stringMaxCharacters))
        {
            result = input;
        }
        if (inputLength > stringMaxCharacters)
        {
            result = input.Substring(0, 20);
        }
        Console.WriteLine(result);
    }
    public static string AddAsterisk(string input, int inputLength)
    {
        int cahrsToAdd = 20 - inputLength;
        input += new string('*', cahrsToAdd);
        return input;
    }
}