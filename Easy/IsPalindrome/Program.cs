public class Solution
{
    /*
     A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
     Given a string s, return true if it is a palindrome, or false otherwise.
     

     Example 1:
     Input: s = "A man, a plan, a canal: Panama"
     Output: true
     Explanation: "amanaplanacanalpanama" is a palindrome.

     Example 2:
     Input: s = "race a car"
     Output: false
     Explanation: "raceacar" is not a palindrome.

     Example 3:
     Input: s = " "
     Output: true
     Explanation: s is an empty string "" after removing non-alphanumeric characters.
     Since an empty string reads the same forward and backward, it is a palindrome.
     */
    public static bool IsPalindrome(string s)
    {
        // Filter the string to include only alphanumeric characters and convert to lowercase
        string pureInput = "";
        foreach (char c in s)
        {
            if (Char.IsLetterOrDigit(c))
            {
                pureInput += Char.ToLower(c);
            }
        }

        // Reverse the filtered string
        string reversed = new string(pureInput.Reverse().ToArray());

        // Check if the filtered string is equal to its reverse
        return pureInput == reversed;
    }

    public static void Main()
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama")); // Output: True
    }
}


