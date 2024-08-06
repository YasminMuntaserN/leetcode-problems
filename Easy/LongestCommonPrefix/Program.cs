using System.Reflection;

public class Solution
{
    #region Description
    /*
    Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string "".
    
    Example 1:
    Input: strs = ["flower","flow","flight"]
    Output: "fl"
    Example 2:
    
    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
    */
    #endregion

    public static void Main()
    {
        string[] strs1 = { "flower", "flow", "flight" };
        string[] strs2 = { "dog", "racecar", "car" };

        Console.WriteLine(LongestCommonPrefix(strs1)); // Output: "fl"
        Console.WriteLine(LongestCommonPrefix(strs2)); // Output: ""
    }

    public static int getSmallestLength(string[] strs)
    {
        // Find the shortest string in the array and return its length
        return strs.OrderBy(str => str.Length).FirstOrDefault().Length;
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        int prefixLength = 0;

        int smallestLength = getSmallestLength(strs);

        // Iterate through each character position up to the length of the shortest string
        for (int i = 0; i < smallestLength; i++)
        {
            // Get the character at the current position in the first string
            char p1 = strs[0][i];

            // Compare this character with the character at the same position in the other strings
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j][i] != p1)
                {
                    return strs[0].Substring(0, prefixLength);
                }
            }

            prefixLength++;
        }

        return strs[0].Substring(0, prefixLength);
    }
}



