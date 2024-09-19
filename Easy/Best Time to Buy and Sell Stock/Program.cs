using System;

public class Solution
{
    /*
     You are given an array prices where prices[i] is the price of a given stock on the ith day.
     You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
     Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
     
     Example 1:
     Input: prices = [7,1,5,3,6,4]
     Output: 5
     Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
     Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
     Example 2:
     
     Input: prices = [7,6,4,3,1]
     Output: 0
     Explanation: In this case, no transactions are done and the max profit = 0.
 
      */
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length < 2) return 0; // Not enough days to make a profit

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            // Update minPrice if the current price is lower
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                // Calculate profit if selling at the current price
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
        }

        return maxProfit;
    }

    static void Main(string[] args)
    {
        // Test cases
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine("Max Profit (Test 1): " + MaxProfit(prices1)); // Expected Output: 5

        int[] prices2 = { 7, 6, 4, 3, 1 };
        Console.WriteLine("Max Profit (Test 2): " + MaxProfit(prices2)); // Expected Output: 0

        int[] prices3 = { 9, 7, 4, 3, 8, 6 };
        Console.WriteLine("Max Profit (Test 3): " + MaxProfit(prices3)); // Expected Output: 5

        int[] prices4 = { 10, 22, 5, 75, 65, 80 };
        Console.WriteLine("Max Profit (Test 4): " + MaxProfit(prices4)); // Expected Output: 75

        int[] prices5 = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Max Profit (Test 5): " + MaxProfit(prices5)); // Expected Output: 4

        int[] prices6 = { };
        Console.WriteLine("Max Profit (Test 6): " + MaxProfit(prices6)); // Expected Output: 0

        int[] prices7 = { 5 };
        Console.WriteLine("Max Profit (Test 7): " + MaxProfit(prices7)); // Expected Output: 0
    }
}