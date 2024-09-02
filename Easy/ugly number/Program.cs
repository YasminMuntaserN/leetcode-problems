public class Solution
{
    /*
     An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.
     Given an integer n, return true if n is an ugly number.
     
     Example 1:
     
     Input: n = 6
     Output: true
     Explanation: 6 = 2 × 3
     Example 2:
     
     Input: n = 1
     Output: true
     Explanation: 1 has no prime factors, therefore all of its prime factors are limited to 2, 3, and 5.
     Example 3:
     
     Input: n = 14
     Output: false
     Explanation: 14 is not ugly since it includes the prime factor 7.
 
     */
    public static  bool IsUgly(int n)
    {
        // If n is less than or equal to 0, return false since negative numbers and 0 are not ugly numbers
        if (n <= 0)
        {
            return false;
        }

        // Console.WriteLine($"--------------- {n} --------------");

        int[] arr = { 2, 3, 5 };// Array containing the prime factors to check against
        int remainder = n;
        // Loop until remainder is reduced to 1 or it can't be divided further by 2, 3, or 5
        while (remainder > 1)
        {
            if (remainder % arr[0] == 0)
            {
                remainder = remainder / arr[0];

            }else if (remainder % arr[1] == 0)
            {
                remainder = remainder / arr[1];
            }
            else if (remainder % arr[2] == 0)
            {
                remainder = remainder / arr[2];
            }
            else
            {
                // If remainder is not divisible by 2, 3, or 5, it's not an ugly number
                return false;   
            }
            //Console.WriteLine(remainder);
        }
        return true;
    }
    public static void Main()
    {
        IsUgly(1);
        IsUgly(30);
        IsUgly(8);
        IsUgly(6);
        IsUgly(14);

    }
}
