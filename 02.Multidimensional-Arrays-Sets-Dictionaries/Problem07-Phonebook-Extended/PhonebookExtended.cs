using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookExtended
{
static void Main()
{
    Dictionary<string, List<string>> phoneNumbers = new Dictionary<string, List<string>>();
    bool isTrue = true;
    string[] info = new string[2];
        string name = "";
        string number = "";
    while (isTrue)
    {
            info = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            name = info[0];
            if (name == "search")
            {
                isTrue = false;
                continue;
            }
            number = info[1];
            if (!phoneNumbers.ContainsKey(name))
            {
                phoneNumbers[name] = new List<string>();

            }
            phoneNumbers[name].Add(number);
    }
        // search
        List<string> search = new List<string>();
        isTrue = true;
        while (isTrue)
        {
            string thatName = Console.ReadLine();
            if (thatName == "")
            {
                isTrue = false;
                continue;
            }
            search.Add(thatName);
        }
        for (int i = 0; i < search.Count; i++)
        {
            int haveThatContact = 0;
            foreach (var item in phoneNumbers)
            {
                if (search[i] == item.Key)
                {
                    Console.WriteLine("{0} -> {1}", search[i], string.Join(", ", phoneNumbers[search[i]]));
                    haveThatContact++;
                }
            }
            if (haveThatContact == 0)
            {
                Console.WriteLine("Contact {0} does not exist.", search[i]);
            }
        }
    }
}
