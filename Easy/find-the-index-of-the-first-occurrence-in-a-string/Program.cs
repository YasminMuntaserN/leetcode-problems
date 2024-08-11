public class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        // Return -1 if either the haystack or needle is empty
        if (haystack.Length == 0 || needle.Length == 0)
            return -1;

        // Loop through the haystack to find the first occurrence of the needle
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            // Check if the current substring matches the needle
            if (haystack.Substring(i, needle.Length) == needle)
            {
                return i;  // Return the starting index of the match
            }
        }

        return -1;  // Return -1 if no match is found

    }
    public static void Main()
    {
        // Test cases
        Console.WriteLine(StrStr("hello", "lo"));          // Expected output: 3
        Console.WriteLine(StrStr("hellohello", "lo"));     // Expected output: 3
        Console.WriteLine(StrStr("aaaaa", "aa"));          // Expected output: 0
        Console.WriteLine(StrStr("abc", "d"));             // Expected output: -1
        Console.WriteLine(StrStr("", "a"));                // Expected output: -1
        Console.WriteLine(StrStr("a", ""));                // Expected output: -1
        Console.WriteLine(StrStr("mississippi", "iss"));   // Expected output: 1
        Console.WriteLine(StrStr("abcdefg", "efg"));       // Expected output: 4
    }
    }
