using System.Numerics;

public class Solution
{
    #region 
    /*
     You are climbing a staircase. It takes n steps to reach the top.

     Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
     
      
     
     Example 1:
     
     Input: n = 2
     Output: 2
     Explanation: There are two ways to climb to the top.
     1. 1 step + 1 step
     2. 2 steps
     Example 2:
     
     Input: n = 3
     Output: 3
     Explanation: There are three ways to climb to the top.
     1. 1 step + 1 step + 1 step
     2. 1 step + 2 steps
     3. 2 steps + 1 step
     */
    #endregion

    public static BigInteger ClimbStairs(int n)
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
        Console.WriteLine(ClimbStairs(45));  // Output: 3


    }
}
