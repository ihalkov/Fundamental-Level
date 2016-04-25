using System;
using System.Collections.Generic;
using System.Linq;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
        bool isTrue = true;
        string[] nameNumber = new string[2];    // 1.name, 2. number
        while (isTrue)
        {
            nameNumber = Console.ReadLine().Split().ToArray();
            if (nameNumber[0] == "search" || (nameNumber[0] == "" && nameNumber[1] == ""))
            {
                isTrue = false;
                continue;
            }
            phoneNumbers[nameNumber[0]] = nameNumber[1];
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
        for (int name = 0; name < search.Count; name++)
        {
            int haveThatContact = 0;
            foreach (var item in phoneNumbers)
            {
                if (search[name] == item.Key)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    haveThatContact++;
                }
            }
            if (haveThatContact == 0)
            {
                Console.WriteLine("Contact {0} does not exist.", search[name]);
            }
        }
    }
}