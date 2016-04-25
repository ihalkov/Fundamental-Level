using System;
using System.Linq;
class ToTheStars
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;
        string[,] starSystem = new string[3, 3];
        string[] input = new string[3];
        for (int i = 0; i < starSystem.GetLength(0); i++)
        {
            input = Console.ReadLine().Split(' ').ToArray();
            starSystem[i, 0] = input[0];        // name
            starSystem[i, 1] = input[1];        // x ->> coord of star
            starSystem[i, 2] = input[2];        // y ->> coord of star
        }
        // normandy coords
        double[] normandyCoords = new double[2];
        normandyCoords = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double coordX = normandyCoords[0];
        double coordY = normandyCoords[1];
        int n = int.Parse(Console.ReadLine()); // numbers of turns of normandy
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(TempCoord(starSystem, coordX, coordY));
            coordY++;
        }

    }

    private static string TempCoord(string[,] starSystem, double coordX, double coordY)
    {
        string exactLocation = "";
        string tempLocation = "";
        for (int star = 0; star < starSystem.GetLength(0); star++)
        {
            tempLocation = CheckForCoincidence(starSystem, star, coordX, coordY);
            if (tempLocation != "space")
            {
                exactLocation = tempLocation;
                break;
            }
            exactLocation = "space";
        }
        return exactLocation;
    }

    private static string CheckForCoincidence(string[,] starSystem, int star, double coordX, double coordY)
    {
        string name = starSystem[star, 0];
        double x = double.Parse(starSystem[star, 1]);
        double y = double.Parse(starSystem[star, 2]);
        string locationForGivenStar = "";
        if ((coordX <= x + 1 && coordX >= x - 1) && (coordY <= y + 1 && coordY >= y - 1))
        {
            locationForGivenStar = name.ToLower();
        }
        else
        {
            locationForGivenStar = "space";
        }
        return locationForGivenStar;
    }
}