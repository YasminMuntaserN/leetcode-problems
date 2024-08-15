using System;

public class Solution
{
    #region
    /*
     You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

       Increment the large integer by one and return the resulting array of digits.
       
        
       
       Example 1:
       
       Input: digits = [1,2,3]
       Output: [1,2,4]
       Explanation: The array represents the integer 123.
       Incrementing by one gives 123 + 1 = 124.
       Thus, the result should be [1,2,4].
       Example 2:
       
       Input: digits = [4,3,2,1]
       Output: [4,3,2,2]
       Explanation: The array represents the integer 4321.
       Incrementing by one gives 4321 + 1 = 4322.
       Thus, the result should be [4,3,2,2].
       Example 3:
       
       Input: digits = [9]
       Output: [1,0]
       Explanation: The array represents the integer 9.
       Incrementing by one gives 9 + 1 = 10.
       Thus, the result should be [1,0].
     */
    #endregion

    public static int[] PlusOne(int[] digits)
    {
        int num = int.Parse(string.Join("", digits)) +1 ;

        int[] array = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

        return array;
    }

    public static void Main()
    {

        // Test case 1
        int[] digits1 = { 1, 2, 3 };
        int[] result1 = PlusOne(digits1);
        Console.WriteLine($"Input: {string.Join(", ", digits1)} -> Output: {string.Join(", ", result1)}");

        // Test case 2 (with a carry-over)
        int[] digits2 = { 9, 9, 9 };
        int[] result2 = PlusOne(digits2);
        Console.WriteLine($"Input: {string.Join(", ", digits2)} -> Output: {string.Join(", ", result2)}");

        // Test case 3 (single digit)
        int[] digits3 = { 0 };
        int[] result3 = PlusOne(digits3);
        Console.WriteLine($"Input: {string.Join(", ", digits3)} -> Output: {string.Join(", ", result3)}");
    }

}
