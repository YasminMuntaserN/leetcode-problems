/*
      You are given a 0-indexed string num of length n consisting of digits.
      Return true if for every index i in the range 0 <= i < n, the digit i occurs num[i] times in num, otherwise return false.
      
      Example 1:
      Input: num = "1210"
      Output: true
      Explanation:
      num[0] = '1'. The digit 0 occurs once in num.
      num[1] = '2'. The digit 1 occurs twice in num.
      num[2] = '1'. The digit 2 occurs once in num.
      num[3] = '0'. The digit 3 occurs zero times in num.
      The condition holds true for every index in "1210", so return true.
      
      Example 2:
      Input: num = "030"
      Output: false
      Explanation:
      num[0] = '0'. The digit 0 should occur zero times, but actually occurs twice in num.
      num[1] = '3'. The digit 1 should occur three times, but actually occurs zero times in num.
      num[2] = '0'. The digit 2 occurs zero times in num.
      The indices 0 and 1 both violate the condition, so return false.
 */
public class Solution
{
    #region Approach 1 [O(n^2)]
    public static bool DigitCount(string num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            int Count = 0; // Initialize count to 0 for each digit i

            for (int j = 0; j < num.Length; j++)
            {
                if (i == int.Parse(num[j].ToString()))
                {
                    Count++; // If a match is found, increment the count
                }
            }

            // Check if the count of digit 'i' matches the value at index 'i' in the string 'num'
            // Convert the character at index 'i' to an integer for the comparison
            if (Count != int.Parse(num[i].ToString()))
            {
                return false;
            }
        }

        return true;
    }
    #endregion
  
    #region Approach 2 [O(n))]
    public static bool DigitCount(string num)
    {
        // Array to store counts of digits (since digits can be 0-9, size is 10)
        int[] digitCounts = new int[10];

        // Step 1: Count the occurrence of each digit in the string 'num'
        for (int i = 0; i < num.Length; i++)
        {
            int digit = int.Parse(num[i].ToString()); // Convert each character to a digit
            digitCounts[digit]++; // Increment the count for that digit
        }
        // Step 2: Verify that the count of each digit matches the value at that index
        for (int i = 0; i < num.Length; i++)
        {
            int expectedCount = int.Parse(num[i].ToString()); // Get the expected count from num[i]
            if (digitCounts[i] != expectedCount)
            {
                return false; // If counts don't match, return false
            }
        }
        // If all counts match, return true
        return true;

    }
    #endregion
    public static void Main()
    {
        Console.WriteLine($"1210 :{DigitCount("1210")}");
        Console.WriteLine($"030 :{DigitCount("030")}");

    }
}
