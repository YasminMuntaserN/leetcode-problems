using System.Collections;
using System.Collections.Generic;
using System.Linq;
/*
     Write a function that takes the binary representation of a positive integer and returns the number of 
       set bits
     it has (also known as the Hamming weight).
    Example 1:
    Input: n = 11
    Output: 3
    Explanation:
    The input binary string 1011 has a total of three set bits.
    
    Example 2:
    Input: n = 128
    Output: 1
    Explanation:
    The input binary string 10000000 has a total of one set bit.
 */
public class Solution
{
    public static List<double> getBits(int n)
    {
        List<double> list = new List<double>();
        double num = 0; int i = 0;
        while (n > num)
        {
            num = Math.Pow(2, i);
            list.Add(num);
            i++;
        }
        return list;
    }

    public static List<double> Represtion(List<double> list, int n)
    {
        List<double> list2 = new List<double>();
        while (n > 1)
        {
            double biger2 = list.FindLast((i) => i < n);
            list2.Add(biger2);

            n -= (int)biger2;
        }
        if (n == 1) list2.Add(1);
        return list2;
    }

    public static string getOnes(List<double> list, List<double> list2)
    {
        string rep = "";

        for (int k = 0; k < list2.Count; k++)
        {
            if (list.Contains(list2[k])) rep += "1";
        }
        return rep; 
    }
    public static int HammingWeight(int n)
    {
        List<double> list = getBits(n);

        if (list.Find((i) => i == n) == n) return 1;

        List<double> list2 = Represtion(list ,n);

        string rep = getOnes(list , list2);
      
        return rep.Count(i => i=='1');
    }

    /*
         public static int HammingWeight(uint n)
    {
        // Convert the integer to its binary representation as a string, then count each 1 using LINQ
        return Convert.ToString(n, 2).Count(Digit => Digit == '1');
    }
     */
    public static void Main()
    {
        Console.WriteLine(HammingWeight(128));
        Console.WriteLine(HammingWeight(11));
        Console.WriteLine(HammingWeight(13));
        Console.WriteLine(HammingWeight(2147483645));



    }
}
