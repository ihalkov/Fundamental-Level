using System;
class SortArrayOfNumbersUsinBubbleSort
{
    static void Main()
    {
        // Read And Process The Input
        string inputEach = Console.ReadLine();
        string[] strArr = inputEach.Split();
        int[] bubble = new int[strArr.Length];

        for (int i = 0; i < bubble.Length; i++)
        {
            bubble[i] = int.Parse(strArr[i]);
        }
        // Print The Result
        Console.WriteLine("[{0}]", string.Join(", ", BubbleSort(bubble)));
    }
    // Implement The Algorithm - Method
    static int[] BubbleSort(int[] bubble)
    {
        int count = 0;
        do
        {
            count = 0;
            for (int i = 0; i < bubble.Length - 1; i++)
            {
                if (bubble[i] > bubble[i + 1])  // swap elements
                {
                    bubble[i] = bubble[i] + bubble[i + 1];  //7 = 4 + 3
                    bubble[i + 1] = bubble[i] - bubble[i + 1];  //      7 - 3 = 4
                    bubble[i] = bubble[i] - bubble[i + 1];   // 7 - 4 = 3
                }
                else
                {
                    count++;    // count not swapped
                }
            }
        } while (count < bubble.Length - 1);
        return bubble;
    }
}