public class Solution
{
    /*
     Given an integer n, return true if it is a power of three. Otherwise, return false.
     An integer n is a power of three, if there exists an integer x such that n == 3x.
     
     Example 1:
     Input: n = 27
     Output: true
     Explanation: 27 = 33
     Example 2:
     
     Input: n = 0
     Output: false
     Explanation: There is no x where 3x = 0.
     Example 3:
     
     Input: n = -1
     Output: false
     Explanation: There is no x where 3x = (-1).
 
      */
    public static bool IsPowerOfThree(int n)
    {
        if (n <= 0) return false;

        while (n > 1)
        {
            if (n % 3 != 0) return false;  // If remainder is not 0, it's not a power of 3
            n = n / 3;
        }
        return true;  // If we've divided down to 1, n is a power of 3
    }
    public static void Main()
    {
        Console.WriteLine("27 : " +IsPowerOfThree(27)+"\n");
        Console.WriteLine("5 : " + IsPowerOfThree(5) + "\n");
        Console.WriteLine("9 : " + IsPowerOfThree(9) + "\n");
        Console.WriteLine("3 : " + IsPowerOfThree(3) + "\n");
        Console.WriteLine("13 : " + IsPowerOfThree(13) + "\n");
        Console.WriteLine("1 : " + IsPowerOfThree(1) + "\n");





    }
}
