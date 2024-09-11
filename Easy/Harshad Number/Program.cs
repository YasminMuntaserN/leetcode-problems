using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    /*
        An integer divisible by the sum of its digits is said to be a Harshad number. You are given an integer x. Return the sum of the digits of x if x is a Harshad number, otherwise, return -1.
       Example 1:
       Input: x = 18
       Output: 9
       Explanation:
       The sum of digits of x is 9. 18 is divisible by 9. So 18 is a Harshad number and the answer is 9.
       
       Example 2:
       Input: x = 23
       Output: -1
       Explanation:
       The sum of digits of x is 5. 23 is not divisible by 5. So 23 is not a Harshad number and the answer is -1.
     */
   
    public static int getSum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    public static int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int sum = getSum(x);

        // Check if x is divisible by sum
        if (sum != 0 && x % sum == 0)
        {
            return sum;
        }
        return -1;
    }

    public static void Main()
    {
        Console.WriteLine($"18: {SumOfTheDigitsOfHarshadNumber(18)}");  // Output: 9
        Console.WriteLine($"23: {SumOfTheDigitsOfHarshadNumber(23)}");  // Output: -1
    }
}
