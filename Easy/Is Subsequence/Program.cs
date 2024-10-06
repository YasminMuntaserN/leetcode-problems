public class Solution

/*
 Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
A subsequence of a string is a new string that is formed from the original string by deleting some (can be none)
of the characters without disturbing the relative positions of the remaining characters.
(i.e., "ace" is a subsequence of "abcde" while "aec" is not).
  */
{
    public static bool IsSubsequence(string s, string t)
    {
        int tIndex = 0;  // Pointer for string t

        // Loop through every character in string s
        for (int i = 0; i < s.Length; i++)
        {
            // Find the next occurrence of s[i] in t, starting from tIndex
            while (tIndex < t.Length && t[tIndex] != s[i])
            {
                tIndex++;  // Keep moving forward in t
            }

            // If we reached the end of t without finding s[i], return false
            if (tIndex == t.Length)
            {
                return false;
            }

            // Move to the next character in t for subsequent matches
            tIndex++;
        }

        // All characters of s were found in order in t
        return true;
    }


    /*
     
    public static  bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length) return false;

         List <int>  lastIndex = new List<int>() ;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    if (lastIndex.Count > i)  // If an index for this character in s already exists
                    {
                        lastIndex[i] = j;  // Update the index
                    }
                    else
                    {
                        lastIndex.Add(j);  // Add the first occurrence
                    }
                }
                }
            if(lastIndex.Count-1 < i) return false;
        }

        return lastIndex.SequenceEqual(lastIndex.OrderBy(x => x));
    }
    */
    public static void Main()
    {
        Console.WriteLine("\"abc\", \"ahbgdc\"" + IsSubsequence("abc", "ahbgdc")); // Output: true
        Console.WriteLine("\"axc\", \"ahbgdc\"" + IsSubsequence("axc", "ahbgdc")); // Output: false
        Console.WriteLine("\"ace\", \"abcde\""+IsSubsequence("ace", "abcde"));  // Output: true
        Console.WriteLine("\"aec\", \"abcde\"" + IsSubsequence("aec", "abcde"));  // Output: false
        Console.WriteLine("s = \"gh\", t = \"gheg\"" + IsSubsequence( "gh", "gheg"));  // Output: false

    }
}
