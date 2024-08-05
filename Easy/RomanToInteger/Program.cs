using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    #region Description
    /*
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
     
     Symbol Value
     I             1
     V             5
     X             10
     L             50
     C             100
     D             500
     M             1000
     For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.
     
     Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
     
     I can be placed before V (5) and X(10) to make 4 and 9. 
     X can be placed before L(50) and C(100) to make 40 and 90. 
     C can be placed before D(500) and M(1000) to make 400 and 900.
    */
    #endregion

    public static int RomanToInt(string s)
    {
        int value = 0;

        // Create and initialize the dictionary to store the characters' values
        Dictionary<char, int> romanToValue = new Dictionary<char, int>
    {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
        {'C', 100}, {'D', 500}, {'M', 1000}
    };

        int p1 = 0, p2 = 0; // Create two pointers: the first to point to the current character and the second to point to the next character

        for (int i = 0; i < s.Length; i++)
        {
            p1 = romanToValue[s[i]]; // Get the value of the current character

            // Check if the current character is not the last one
            if (i + 1 < s.Length)
            {
                p2 = romanToValue[s[i + 1]]; // Get the value of the next character

                // If the current value is less than the next value, it's a subtraction case (e.g.,CM ,IV, IX)
                if (p1 < p2)
                {
                    value += (p2 - p1);
                    i++; // Skip the next character as it has been processed in the subtraction pair
                }
                else
                {
                    value += p1; // Add the current value to the total value
                }
            }
            else
            {
                // If it's the last character, just add its value to the total
                value += p1;
            }
        }

        return value; // Return the total integer value
    }

    static void Main()
    {
        // Example usage: Convert Roman numeral to integer
        string romanNumeral = "MCMXCIV";
        //    string romanNumeral = "III";

        int result = RomanToInt(romanNumeral);
        Console.WriteLine(result);  // Output: 1994
    }
}
