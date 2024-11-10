using System;
using System.Linq;

public class Solution
{
    public static string XOR(string s1, string s2)
    {
        string rep = "";
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i]) rep += "1";
            else rep += "0";
        }
        return rep;
    }

    public static string RepresentBinary(int num)
    {
        string rep = "";

            for (int i = 31; i >= 0; i--)
            {
                if ((num & (1 << i)) != 0)
                    rep += '1';
                else
                    rep += '0';
            }
        return rep;
    }

    public static int HammingDistance(int x, int y)
    {
        return XOR(RepresentBinary(x), RepresentBinary(y)).Count(c => c == '1');
    }

    #region simple solution
    /*
    public int HammingDistance(int x, int y)
    {
        string bin_x = Convert.ToString(x, 2);
        string bin_y = Convert.ToString(y, 2);

        int output = x ^ y;
        string str_output = Convert.ToString(output, 2);
        int number = 0;
        for (int i = 0; i < str_output.Length; i++)
        {
            if (str_output[i] == '1')
            {
                number++;
            }
        }

        return number;
    }
    */
    #endregion
    public static void Main()
    {
        Console.WriteLine(HammingDistance(1, 4));           
        Console.WriteLine(HammingDistance(3, 1));   
        Console.WriteLine(HammingDistance(2, 8));  
        Console.WriteLine(HammingDistance(10, 7)); 
    }
}

