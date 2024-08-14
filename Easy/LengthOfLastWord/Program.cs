using System.Linq;

public class Solution
{
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
