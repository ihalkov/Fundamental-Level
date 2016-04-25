using System;
using System.Collections.Generic;
using System.Linq;
class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> dict =
            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        string input = Console.ReadLine();
        string[] holdInput = new string[3];
        while (input != "END")
        {
            holdInput = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string city = holdInput[0];
            string venue = holdInput[1];
            string performers = holdInput[2];
            if (!dict.ContainsKey(city))
            {
                dict[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!dict[city].ContainsKey(venue))
            {
                dict[city][venue] = new SortedSet<string>();
            }
            dict[city][venue].Add(performers);
            input = Console.ReadLine();
        };
        // print
        foreach (var city in dict.Keys)
        {
            Console.WriteLine("{0}", city);
            foreach (var venue in dict[city].Keys)  // keys in cities; venue
            {
                Console.Write("->{0}: ", venue);
                foreach (var performer in dict[city][venue])    // values in each city, venue is performers
                {
                    Console.WriteLine(string.Join("{0}, ", performer));
                }
            }
        }
    }
}