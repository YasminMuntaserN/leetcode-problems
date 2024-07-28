using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
public class Soluation
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;

        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }

        return maxLength;
    }

    public static void Main()
    {
        string inputStr = "bbbbb";
        Console.WriteLine($"The length of the longest substring without repeating characters in '{inputStr}' is {LengthOfLongestSubstring(inputStr)}");
    }
}

