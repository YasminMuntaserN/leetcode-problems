public class Solution
{
    public static int ClimbStairs(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        if (n == 2)
        {
            return 2;
        }
        
        for (int i = 3; i <= n; i++)
        {
            return ClimbStairs((n - 1)) + ClimbStairs(n - 2);
        }
        return 0;
    }

    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(ClimbStairs(8
            ));  // Output: 2
        Console.WriteLine(ClimbStairs(3));  // Output: 3
        Console.WriteLine(ClimbStairs(6));  // Output: 3
        Console.WriteLine(ClimbStairs(44));  // Output: 3
        Console.WriteLine(ClimbStairs(43));  // Output: 3
        Console.WriteLine(ClimbStairs(45));  // Output: 3




    }
}
