using System.Linq;

public class Solution
{
    #region
    /*Given a string s consisting of words and spaces, return the length of the last word in the string.

    A word is a maximal 
    substring
    consisting of non-space characters only.



    Example 1:

    Input: s = "Hello World"
    Output: 5
    Explanation: The last word is "World" with length 5.
    Example 2:

    Input: s = "   fly me   to   the moon  "
    Output: 4
    Explanation: The last word is "moon" with length 4.
    Example 3:

    Input: s = "luffy is still joyboy"
    Output: 6
    Explanation: The last word is "joyboy" with length 6.*/
    #endregion
    public static int LengthOfLastWord(string s)
    {
        // Trim the string to remove any leading or trailing whitespace
        s = s.Trim();

        // Find the index of the last space in the trimmed string
        int lastSpaceIndex = s.LastIndexOf(' ');

        // The last word starts after the last space, so calculate its length
        int lengthOfLastWord = s.Length - lastSpaceIndex - 1;

        return lengthOfLastWord;
    }

    public static void Main()
    {
        string s = "  fly me   to   the moon   ";
        Console.WriteLine(LengthOfLastWord(s));

        string s1 = "Hello World";
        Console.WriteLine(LengthOfLastWord(s1));

        string s2 = "luffy is still joyboy";
        Console.WriteLine(LengthOfLastWord(s2));
    }
}
