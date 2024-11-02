using static System.Runtime.InteropServices.JavaScript.JSType;
/*
    Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
    
    Example 1:
    Input: n = 2
    Output: [0,1,1]
    Explanation:
    0 --> 0
    1 --> 1
    2 --> 10 

 */
public class Solution
{
    public static int Sum(string rep)
    {
        List <char> list = new List <char> (rep);
        int sum = 0;
        for (int i = 0; i < rep.Length; i++)
        {
            sum += (int)char.GetNumericValue(rep[i]);

        }
        return sum;
    }
    public static int[] CountBits(int n)
    {
        int[] bits = new int[n+1];
        for (int i = 0; i <= n; i++)
        {
            bits[i] = Sum(Convert.ToString(i, 2));
        }
        return bits;
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(" , ", CountBits(2)));
        Console.WriteLine(string.Join(" , ", CountBits(5)));

    }
}
