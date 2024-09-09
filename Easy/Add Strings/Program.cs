using System.Text;

public class Solution
{
    /*
     Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.
     You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.
     
     Example 1:
     Input: num1 = "11", num2 = "123"
     Output: "134"
     
     Example 2:
     Input: num1 = "456", num2 = "77"
     Output: "533"
     
     Example 3:
     Input: num1 = "0", num2 = "0"
     Output: "0"
     */

    public static string AddStrings(string num1, string num2)
    {
        int length1 = num1.Length - 1, length2 = num2.Length - 1;
        int carry = 0;
        StringBuilder sumAsString = new();

        while (length1 >= 0 || length2 >= 0 || carry > 0)
        {
            //Converted num1[length1] - '0' to extract the integer value of the character.
            int p1 = length1 >= 0 ? num1[length1] - '0' : 0;
            int p2 = length2 >= 0 ? num2[length2] - '0' : 0;

            int sumOfNumbers = p1 + p2 + carry;
            carry = sumOfNumbers / 10;

            // Append the least significant digit to the result
            sumAsString.Append((sumOfNumbers % 10).ToString());

            // Move to the next digits
            length1--;
            length2--;
        }

        // Reverse the result since we built it backwards
        char[] resultArray = sumAsString.ToString().ToCharArray();
        Array.Reverse(resultArray);

        return new string(resultArray);
    }

    public static void Main(string[] args)
    {
        

        // Test cases
        string result1 = AddStrings("11", "123");
        string result2 = AddStrings("456", "77");
        string result3 = AddStrings("0", "0");

        // Output results
        Console.WriteLine($"Result of adding 11 and 123: {result1}");  // Expected: "134"
        Console.WriteLine($"Result of adding 456 and 77: {result2}");  // Expected: "533"
        Console.WriteLine($"Result of adding 0 and 0: {result3}");     // Expected: "0"
    }
}
