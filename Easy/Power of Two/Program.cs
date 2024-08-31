public class Solution
{
    /*
     Given an integer n, return true if it is a power of two. Otherwise, return false.
     An integer n is a power of two, if there exists an integer x such that n == 2x.
     
     Example 1:
     
     Input: n = 1
     Output: true
     Explanation: 20 = 1
     Example 2:
     
     Input: n = 16
     Output: true
     Explanation: 24 = 16
     Example 3:
     
     Input: n = 3
     Output: false
     */
    public static bool IsPowerOfTwo(int n)
    {
        // If the number is less than or equal to zero, it can't be a power of two
        if (n <= 0) return false;

        // Keep dividing the number by 2 as long as it is divisible by 2
        while (n % 2 == 0)
        {
            n /= 2;
        }

        // If we reach 1, then n was a power of two
        return n == 1;
    }

    public static void Main()
    {
        Console.WriteLine(" 1 " +IsPowerOfTwo(1)); // True
        Console.WriteLine(" 2 " + IsPowerOfTwo(2)); // True
        Console.WriteLine(" 3 " + IsPowerOfTwo(3)); // False
        Console.WriteLine(" 6 " + IsPowerOfTwo(6)); // False
        Console.WriteLine(" 4 " + IsPowerOfTwo(4)); // True
        Console.WriteLine(" 0 " + IsPowerOfTwo(0)); // False
        Console.WriteLine(" -16 " + IsPowerOfTwo(-16)); // False
    }
}
