public class Solution
{
    /*
      Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
       Example 1:
       Input: num = 38
       Output: 2
       Explanation: The process is
       38 --> 3 + 8 --> 11
       11 --> 1 + 1 --> 2 
       Since 2 has only one digit, return it.
      */

    public static int sumDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    public static int AddDigits(int num)
    {
        int lastNum = sumDigits(num);
        while (lastNum >= 10)
        {  
            lastNum = sumDigits(lastNum);
        }
        return lastNum;
    }
   
    public static void Main()
    {
        Console.WriteLine(AddDigits(38));
        Console.WriteLine(AddDigits(3));
        Console.WriteLine( AddDigits(9875));
        Console.WriteLine(AddDigits(123));

    }
}
