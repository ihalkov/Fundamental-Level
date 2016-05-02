using System;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string bannedWords = "Linux, Windows";
        string[] banned = bannedWords.Split(new string[] { ",", " "}, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder bannedText = new StringBuilder(Console.ReadLine());
        for (int i = 0; i < banned.Length; i++)
        {
            int asteriskL = banned[i].Length;
            string aterisks = new string('*', asteriskL);
            bannedText.Replace(banned[i], aterisks);
        }
        Console.WriteLine(bannedText.ToString());
    }
}