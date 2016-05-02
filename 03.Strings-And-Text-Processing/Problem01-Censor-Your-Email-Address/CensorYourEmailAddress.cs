using System;
using System.Text;

class CensorYourEmailAddress
{
    static void Main()
    {
        string email = "pesho.peshev@email.bg";
        string text = "My name is Pesho Peshev. I am from Sofia, my email is: pesho.peshev@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, pesho.peshev@email.bg";

        string[] exactText = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        // ", ", ". ", "(", ")", ":"
        string[] formatedText = text.Split(new string[] { " ", ", ", ". ", "(", ")", ":" }, StringSplitOptions.RemoveEmptyEntries);
        for (int word = 0; word < exactText.Length; word++)
        {
            string thisWord = formatedText[word];
            if (email.Equals(thisWord))
            {
                exactText[word] = ReplaceString(thisWord);
            }
        }
        Console.WriteLine(string.Join(" ", exactText));
    }

    public static string ReplaceString(string email)
    {
        StringBuilder sb = new StringBuilder(email);
        string[] parts = email.Split('@');
        string oldStr = parts[0];
        string newStr = new string('*', parts[0].Length);
        sb.Replace(oldStr, newStr);
        string result = sb.ToString();
        return result;
    }
}