using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    public static ArrayList Divisors(int n)
    {
        ArrayList list = new ArrayList();

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                list.Add(new int[] { n / i, i });
            }
        }

        return list;
    }

    public static int[] ConstructRectangle(int area)
    {
        ArrayList divisors = Divisors(area);

        if (divisors.Count == 0)
        {
            return new int[] { area, 1 }; // For prime numbers LIKE 37
        }

        int minDiff = int.MaxValue;
        int[] result = new int[2];

        foreach (var pair in divisors)
        {
            int[] divisorPair = (int[])pair;
            int L = divisorPair[0];
            int W = divisorPair[1];

            if (L >= W)
            {
                int count = L - W;

                if (count < minDiff)
                {
                    minDiff = count;
                    result = new int[] { L, W };
                }
            }
        }

        return result;
    }

    public static void Main()
    {
        int area2 = 37;
        int[] result2 = ConstructRectangle(area2);
        Console.WriteLine($"Optimal dimensions for area {area2} are: [{result2[0]}, {result2[1]}]");

        int area1 = 36;
        int[] result1 = ConstructRectangle(area1);
        Console.WriteLine($"Optimal dimensions for area {area1} are: [{result1[0]}, {result1[1]}]");

        int area3 = 4;
        int[] result3 = ConstructRectangle(area3);
        Console.WriteLine($"Optimal dimensions for area {area3} are: [{result3[0]}, {result3[1]}]");



        int area4 = 122122;
        int[] result4 = ConstructRectangle(area4);
        Console.WriteLine($"Optimal dimensions for area {area4} are: [{result4[0]}, {result4[1]}]");
    }
}
