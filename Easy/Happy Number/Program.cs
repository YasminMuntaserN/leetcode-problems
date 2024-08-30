using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static List<int> GetSequenceOfNumbers(int n)
    {
        List<int> list = new List<int>();
        while (n > 0)
        {
            int remainder = n % 10;
            list.Add(remainder);
            n /= 10;
        }
        return list;
    }

    public static bool IsHappy(int n)
    {
        HashSet<int> seenBefore = new HashSet<int>();

        while (n != 1 && !seenBefore.Contains(n))
        {
            seenBefore.Add(n);
            List<int> list = GetSequenceOfNumbers(n);
            int sum = 0;
            foreach (int num in list)
            {
                sum += num * num;
            }
            Console.WriteLine($"Sum: {sum}");
            n = sum;
        }

        return n == 1;
    }

    public static void Main()
    {
        int num = 19;
        bool result = IsHappy(num);
        Console.WriteLine($"{num} is a happy number: {result}");
    }
}
