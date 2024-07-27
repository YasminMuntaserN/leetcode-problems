using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    #region Question Description
       /* You are given an integer num.Rearrange the digits of num such that its value is minimized and it does not contain any leading zeros.
         
          Return the rearranged number with minimal value.
         
          Note that the sign of the number does not change after rearranging the digits.
       */
    #endregion
    public static void Swap(char[] array, long i, long j)
    {
        char temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static char[] PossibleNumbers(long Number)
    {
        char[] digits = Number.ToString().ToCharArray();
        Array.Sort(digits);
        if (digits[0] == '0')
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] != '0')
                {
                    Swap(digits, 0, i);
                    break;
                }
            }
        }
        return digits;
    }

    public static long SmallestNumber(long num)
    {
        long SmallestNumber = 0;
        char[] Number;
        if (num > 0)
        {
            Number = PossibleNumbers(num);
            SmallestNumber = long.Parse(new string(Number));
        }
        else
        {
            Number = PossibleNumbers(num * -1);
            Array.Sort(Number);
            Array.Reverse(Number);
            SmallestNumber = -long.Parse(new string(Number));
        }
        return SmallestNumber;
        ;
    }

    public static void Main()
    {
        Console.WriteLine($" The smallest : {SmallestNumber(310)}");
    }


}
