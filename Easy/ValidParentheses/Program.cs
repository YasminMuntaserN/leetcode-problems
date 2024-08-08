using System.Collections.Generic;
using System.Threading.Tasks;

public class Solution
{
    #region
    /*
      Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

      An input string is valid if:
      
      Open brackets must be closed by the same type of brackets.
      Open brackets must be closed in the correct order.
      Every close bracket has a corresponding open bracket of the same type.
     */
    #endregion

    public static void Main()
    {
        // Example inputs
        string s1 = "(";
        string s2 = "()[]{}";
        string s3 = "(]";
        string s4 = "[{]}";

        // Output results for each example input
        Console.WriteLine(IsValid(s1)); // Output: true
        Console.WriteLine(IsValid(s2)); // Output: true
        Console.WriteLine(IsValid(s3)); // Output: false
        Console.WriteLine(IsValid(s4)); // Output: false
    }

    public static bool IsValid(string s)
    {
        // Dictionary to map each closing bracket to its corresponding opening bracket
        Dictionary<char, char> bracketMap = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        if (s.Length == 1 && s.Length == 0)
        {
            return false;
        }
        List<char> openBrackets = new List<char>();

        foreach (char c in s)
        {
            // If the character is a closing bracket
            if (bracketMap.ContainsKey(c))
            {
                // Check if there are no open brackets or the last open bracket doesn't match
                char LastOpernBracket = openBrackets[openBrackets.Count - 1];   
             
                if (openBrackets.Count == 0 || LastOpernBracket != bracketMap[c])
                {
                    return false; // No matching opening bracket or mismatch found
               
                }
                openBrackets.Remove(LastOpernBracket);
            }
            // If the character is an opening bracket
            else
            {
                // Add the opening bracket to the list
                openBrackets.Add(c);
            }
        }

        // The input string is valid if the list is empty (all brackets matched)
        return openBrackets.Count == 0;
    }
}

