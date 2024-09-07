public class Solution
{
    /*
     Given an integer n, return true if it is a power of four. Otherwise, return false.
     An integer n is a power of four, if there exists an integer x such that n == 4x.
     Example 1:
     Input: n = 16
     Output: true

     Example 2:
     Input: n = 5
     Output: false

     Example 3:
     Input: n = 1
     Output: true
     */
    public static bool IsPowerOfFour(int n)
    {
        // Powers of 4 are always positive, so if n is <= 0, return false.
        if (n <= 0) return false;

        while (n > 1)
        {
            // If the remainder is not 0, n is not a power of 4, so return false.
            int remainder = n % 4;
            if (remainder != 0) return false;

            // If n is divisible by 4 (remainder == 0), divide n by 4.
            n /= 4;
        }

        // This means the original number was a power of 4, so return true.
        return true;
    }

    public static void Main()
    {
        Console.WriteLine("4 : " + IsPowerOfFour(4));
        Console.WriteLine("5 : " + IsPowerOfFour(5));
        Console.WriteLine("16 : " + IsPowerOfFour(16));
        Console.WriteLine("256 : " + IsPowerOfFour(256));
        Console.WriteLine("17 : " + IsPowerOfFour(17));


    }
}
