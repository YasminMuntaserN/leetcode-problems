public class Solution
{
    /*
        You have n coins and you want to build a staircase with these coins. The staircase consists of k rows where the ith row has exactly i coins. The last row of the staircase may be incomplete.
        Given the integer n, return the number of complete rows of the staircase you will build.
        Example 1:
        Input: n = 5
        Output: 2
        Explanation: Because the 3rd row is incomplete, we return 2.
        
        Example 2:
        Input: n = 8
        Output: 3
        Explanation: Because the 4th row is incomplete, we return 3.
         
     */
    /* public static int ArrangeCoins(int n)
     {
         if (n == 0) return 0;
         if (n == 1) return 1;  

         int i = 0;
         while (n >= i + 1)  
         {
             i++;
             n = n - i;
             Console.WriteLine("n: " + n + "  i: " + i);
         }
         return i;
     }*/

    public static int ArrangeCoins(int n)
    {
        long left = 0, right = n;  // Use long to avoid overflow in calculations

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long currentSum = mid * (mid + 1) / 2;

            if (currentSum == n)
            {
                return (int)mid;  // Found exact match
            }
            else if (currentSum < n)
            {
                left = mid + 1;  // Look for larger k
            }
            else
            {
                right = mid - 1;  // Look for smaller k
            }
        }

        return (int)right;
    }

    public static void Main()
    {
        Console.WriteLine("8 : " + ArrangeCoins(8));
        Console.WriteLine("5 : " + ArrangeCoins(5));
        Console.WriteLine("10 : " + ArrangeCoins(10));
        Console.WriteLine("3 : " + ArrangeCoins(3));
        Console.WriteLine("20 : " + ArrangeCoins(20));

    }
}
