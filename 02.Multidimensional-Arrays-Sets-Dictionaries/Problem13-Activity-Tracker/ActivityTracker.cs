using System;
using System.Collections.Generic;
using System.Linq;
class ActivityTracker
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;
        // input
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<int, SortedDictionary<string, int>> data = HoldData(n);
        // print
        foreach (var month in data.Keys)
        {
            Console.Write("{0}: ", month);
            List<string> temp = new List<string>();
            foreach (var name in data[month].Keys)  // keys in month; names
            {
                string t = "" + name + "(" + data[month][name] + ")";
                temp.Add(t);
            }
            Console.WriteLine(string.Join(", ", temp));
        }

    }

    //static List<DateTime> SortMonthAscending(SortedDictionary<DateTime, SortedDictionary<string, string>> data)
    //{

    //}
    private static SortedDictionary<int, SortedDictionary<string, int>> HoldData(int n)
    {
        SortedDictionary<int, SortedDictionary<string, int>> dict =
           new SortedDictionary<int, SortedDictionary<string, int>>();
        string[] holdInput = new string[3];
        while (n > 0)
        {
            string input = Console.ReadLine();
            holdInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string strDate = holdInput[0];
            string[] monthArr = holdInput[0].Split('/').ToArray();
            int month = int.Parse(monthArr[1]);
            string name = holdInput[1];
            int distance = int.Parse(holdInput[2]);
            if (!dict.ContainsKey(month))
            {
                dict[month] = new SortedDictionary<string, int>();
            }

            if (!dict[month].ContainsKey(name))
            {
                dict[month][name] = 0;
            }
            dict[month][name] += distance;
            n--;
        }
        return dict;
    }
}