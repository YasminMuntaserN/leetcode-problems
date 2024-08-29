using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

public class Solution
{
    /*
     Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.
     For example:
     A -> 1
     B -> 2
     C -> 3
     ...
     Z -> 26
     AA -> 27
     AB -> 28 
     ...
     
     Example 1:
     
     Input: columnTitle = "A"
     Output: 1
     Example 2:
     
     Input: columnTitle = "AB"
     Output: 28
     Example 3:
     
     Input: columnTitle = "ZY"
     Output: 701
     */
    public static int TitleToNumber(string columnTitle)
    {
        int result = 0;

        // Iterate through each character in the string
        for (int i = 0; i < columnTitle.Length; i++)
        {
            // Convert the character to its corresponding value (A = 1, B = 2, ..., Z = 26)
            int charValue = columnTitle[i] - 'A' + 1;

            // Accumulate the result by multiplying the previous result by 26 and adding the current charValue
            result = result * 26 + charValue;
        }

        return result;
    }

    public static void Main()
    {
        Console.WriteLine(TitleToNumber("A"));   // Output: 1
        Console.WriteLine(TitleToNumber("Z"));   // Output: 26
        Console.WriteLine(TitleToNumber("AA"));  // Output: 27
        Console.WriteLine(TitleToNumber("AB"));  // Output: 28
        Console.WriteLine(TitleToNumber("ZY"));  // Output: 701
    }
}
